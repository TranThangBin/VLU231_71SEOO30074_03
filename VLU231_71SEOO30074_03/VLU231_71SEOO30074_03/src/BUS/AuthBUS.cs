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
                bool isAuthorized = await db.NguoiDungs.AnyAsync(
                    nguoiDung => nguoiDung.TenTk == username && nguoiDung.MatKhau == password
                );
                if (!isAuthorized)
                {
                    user = null;
                    return false;
                }
                user = db.NguoiDungs.First(
                    nguoiDung => nguoiDung.TenTk == username && nguoiDung.MatKhau == password
                );
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
