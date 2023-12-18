using System;
using System.Data.Entity;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class KhoaBUS
    {
        public static void UseKhoas(Action<DbSet<Khoa>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.Khoas);
            }
        }

        private static Error ValidateConstraint(Khoa khoa)
        {
            if (khoa.Ma.Length < 8)
            {
                return Error.New("Mã khoa cần tối thiểu 8 ký tự");
            }
            if (khoa.Ten.Length < 5)
            {
                return Error.New("Tên khoa cần tối thiểu 5 ký tự");
            }
            if (khoa.Sdt.Length < 10)
            {
                return Error.New("Số điện thoại cần tối thiểu 10 ký tự");
            }
            if (khoa.Sdt.First() != '0')
            {
                return Error.New("Số điên thoại phải bắt đầu với ký tự \'0\'");
            }
            if (!khoa.Sdt.All(ch => char.IsDigit(ch)))
            {
                return Error.New("Tồn tại ký tự khác số trong số điện thoại");
            }
            if (khoa.DiadiemVp.Length < 10)
            {
                return Error.New("Địa điểm văn phòng cần tối thiểu 10 ký tự");
            }
            return null;
        }

        public static Result<Khoa> InsertKhoa(Khoa khoa)
        {
            using (var db = new QLDKHPEntities())
            {
                if (db.Khoas.Any(k => k.Ma == khoa.Ma))
                {
                    return Result<Khoa>.Failure("Đã tồn tại khoa với mã trên");
                }
                Error error = ValidateConstraint(khoa);
                if (error != null)
                {
                    return Result<Khoa>.Failure(error);
                }
                Khoa kh = db.Khoas.Add(khoa);
                db.SaveChanges();
                return Result<Khoa>.Success(kh);
            }
        }

        public static Result<Khoa> UpdateKhoa(string maKhoa, Khoa khoaMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if (k == null)
                {
                    return Result<Khoa>.Failure("Không tìm thấy khoa");
                }
                Error error = ValidateConstraint(khoaMoi);
                if (error != null)
                {
                    return Result<Khoa>.Failure(error);
                }
                k.Ten = khoaMoi.Ten;
                k.Sdt = khoaMoi.Sdt;
                k.DiadiemVp = khoaMoi.DiadiemVp;
                db.SaveChanges();
                return Result<Khoa>.Success(k);
            }
        }

        public static Result<Khoa> DeleteKhoa(string maKhoa)
        {
            using (var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if (k == null)
                {
                    return Result<Khoa>.Failure("Không tìm thấy khoa");
                }
                if (k.NguoiDungs.Count > 0)
                {
                    return Result<Khoa>.Failure("Không thể xóa vì có người dùng thuộc khoa này");
                }
                if (k.MonHocs.Count > 0)
                {
                    return Result<Khoa>.Failure("Không thể xóa vì có môn học thuộc khoa này");
                }
                db.Khoas.Remove(k);
                db.SaveChanges();
                return Result<Khoa>.Success(k);
            }
        }
    }
}
