using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class AuthBUS
    {
        private static string userId;

        public static void UseUser(Action<NguoiDung> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.NguoiDungs.Find(userId));
            }
        }

        public static bool IsAuthenticate()
        {
            return userId != string.Empty;
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
                    userId = string.Empty;
                    return false;
                }
                userId = taiKhoan.MaNgD;
            }
            return true;
        }

        public static bool Logout()
        {
            userId = string.Empty;
            return true;
        }
    }
}
