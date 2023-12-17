using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class AuthBUS
    {
        private static NguoiDung user;
        public static NguoiDung User
        {
            get => user;
        }

        public static bool IsAuthenticate()
        {
            return user != null;
        }

        public static async Task<bool> Login(string username, string password)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = await db.TaiKhoans.FirstOrDefaultAsync(
                    nguoiDung => nguoiDung.TenTk == username && nguoiDung.MatKhau == password
                );
                if (taiKhoan == null)
                {
                    return false;
                }
                switch (taiKhoan.NguoiDung.Loai)
                {
                    case (byte)LoaiNguoiDung.GiangVien:
                        user = await db.NguoiDungs
                            .Include(giangVien => giangVien.Khoa)
                            .Include(giangVien => giangVien.LopHps)
                            .FirstAsync(nguoiDung => nguoiDung.Ma == taiKhoan.MaNgD);
                        break;
                    case (byte)LoaiNguoiDung.SinhVien:
                        user = await db.NguoiDungs
                            .Include(sinhVien => sinhVien.Khoa)
                            .Include(sinhVien => sinhVien.LopHps)
                            .Include(sinhVien => sinhVien.SinhvienHps)
                            .FirstAsync(nguoiDung => nguoiDung.Ma == taiKhoan.MaNgD);
                        break;
                    default:
                        user = await db.NguoiDungs.FindAsync(taiKhoan.MaNgD);
                        break;
                }
            }
            return true;
        }

        public static bool Logout()
        {
            user = null;
            return true;
        }
    }
}
