using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class TaiKhoanBUS
    {
        public static TaiKhoan GetTaiKhoan(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                return db.TaiKhoans.Find(maNgD);
            }
        }

        private static Error ValidateConstraint(TaiKhoan taiKhoan)
        {
            if (taiKhoan.TenTk.Length < 5)
            {
                return Error.New("Tên tài khoản cần tối thiểu 5 ký tự");
            }
            if (taiKhoan.MatKhau.Length < 8)
            {
                return Error.New("Mật khẩu cần tối thiểu 8 ký tự");
            }
            if (!taiKhoan.MatKhau.Any(ch => char.IsDigit(ch)))
            {
                return Error.New("Mật khẩu cần tối thiểu 1 chữ số");
            }
            if (!taiKhoan.MatKhau.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return Error.New("Mật khẩu cần tối thiểu 1 ký tự đặc biệt");
            }
            return null;
        }

        public static Result<TaiKhoan> InsertTaiKhoan(string maNgD, TaiKhoan taiKhoan)
        {
            using (var db = new QLDKHPEntities())
            {
                if (db.TaiKhoans.Any(tk => tk.MaNgD == maNgD))
                {
                    return Result<TaiKhoan>.Failure("Người dùng này đã có tài khoản");
                }
                Error error = ValidateConstraint(taiKhoan);
                if (error != null)
                {
                    return Result<TaiKhoan>.Failure(error);
                }
                taiKhoan.MaNgD = maNgD;
                TaiKhoan Tk = db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
                return Result<TaiKhoan>.Success(Tk);
            }
        }

        public static Result<TaiKhoan> UpdateTaiKhoan(string maNgD, TaiKhoan taiKhoanMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan == null)
                {
                    return Result<TaiKhoan>.Failure("Không tìm thấy tài khoản");
                }
                Error error = ValidateConstraint(taiKhoanMoi);
                if (error != null)
                {
                    return Result<TaiKhoan>.Failure(error);
                }
                taiKhoan.TenTk = taiKhoanMoi.TenTk;
                taiKhoan.MatKhau = taiKhoanMoi.MatKhau;
                db.SaveChanges();
                return Result<TaiKhoan>.Success(taiKhoan);
            }
        }

        public static Result<TaiKhoan> DeleteTaiKhoan(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan == null)
                {
                    return Result<TaiKhoan>.Failure("Không tìm thấy tài khoản");
                }
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
                return Result<TaiKhoan>.Success(taiKhoan);
            }
        }
    }
}
