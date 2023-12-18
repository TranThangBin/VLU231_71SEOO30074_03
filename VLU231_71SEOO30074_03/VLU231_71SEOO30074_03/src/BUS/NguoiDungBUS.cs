using System.Linq;
using System;

namespace VLU231_71SEOO30074_03.src.BUS
{
    public enum LoaiNguoiDung
    {
        GiangVien = 1,
        SinhVien = 2,
    }

    internal class NguoiDungBUS
    {
        public static void UseNguoiDungs(
            LoaiNguoiDung loaiNguoiDung,
            Action<IQueryable<NguoiDung>> callback
        )
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.NguoiDungs.Where(nguoiDung => nguoiDung.Loai == (byte)loaiNguoiDung));
            }
        }

        private static Error ValidateConstraint(NguoiDung nguoiDung)
        {
            if (nguoiDung.Ma.Length < 8)
            {
                return Error.New("Mã người dùng cần tối thiểu 8 ký tự");
            }
            if (string.IsNullOrEmpty(nguoiDung.HoTen))
            {
                return Error.New("Họ tên trống");
            }
            if (nguoiDung.NgaySinh > DateTime.Now)
            {
                return Error.New("Ngày sinh không được lớn hơn thời điểm hiện tại");
            }
            if (string.IsNullOrEmpty(nguoiDung.QueQuan))
            {
                return Error.New("Quê quán trống");
            }
            if (string.IsNullOrEmpty(nguoiDung.DiaChi))
            {
                return Error.New("Địa chỉ trống");
            }
            return null;
        }

        public static Result<NguoiDung> InsertNguoiDung(
            NguoiDung nguoiDung,
            LoaiNguoiDung loaiNguoiDung
        )
        {
            using (var db = new QLDKHPEntities())
            {
                if (db.NguoiDungs.Any(ngDung => ngDung.Ma == nguoiDung.Ma))
                {
                    return Result<NguoiDung>.Failure("Đã tồn tại người dùng với mã trên");
                }
                Error error = ValidateConstraint(nguoiDung);
                if (error != null)
                {
                    return Result<NguoiDung>.Failure(error);
                }
                nguoiDung.Loai = (byte)loaiNguoiDung;
                NguoiDung ngD = db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
                return Result<NguoiDung>.Success(ngD);
            }
        }

        public static Result<NguoiDung> UpdateNguoiDung(string maNgD, NguoiDung nguoiDungMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung == null)
                {
                    return Result<NguoiDung>.Failure("Không tìm thấy người dùng");
                }
                Error error = ValidateConstraint(nguoiDungMoi);
                if (error != null)
                {
                    return Result<NguoiDung>.Failure(error);
                }
                nguoiDung.HoTen = nguoiDungMoi.HoTen;
                nguoiDung.MaKhoa = nguoiDungMoi.MaKhoa;
                nguoiDung.NgaySinh = nguoiDungMoi.NgaySinh;
                nguoiDung.GioiTinh = nguoiDungMoi.GioiTinh;
                nguoiDung.QueQuan = nguoiDungMoi.QueQuan;
                nguoiDung.DiaChi = nguoiDungMoi.DiaChi;
                db.SaveChanges();
                return Result<NguoiDung>.Success(nguoiDung);
            }
        }

        public static Result<NguoiDung> DeleteNguoiDung(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung == null)
                {
                    return Result<NguoiDung>.Failure("Không tìm thấy người dùng");
                }
                if (nguoiDung.LopHps.Count > 0)
                {
                    return Result<NguoiDung>.Failure(
                        "Không thể xóa vì người dùng đã tham gia các lớp học phần"
                    );
                }
                if (nguoiDung.TaiKhoan != null)
                {
                    return Result<NguoiDung>.Failure(
                        "Cần phải xóa tài khoản trước khi xóa người dùng"
                    );
                }
                db.NguoiDungs.Remove(nguoiDung);
                db.SaveChanges();
                return Result<NguoiDung>.Success(nguoiDung);
            }
        }
    }
}
