using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class AuthBUS
    {
        public static int Login(string username, string password)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung user = db.NguoiDungs.First(
                    nguoiDung => nguoiDung.TenTk == username && nguoiDung.MatKhau == password
                );
                if (user != null)
                {
                    return user.Loai;
                }
            }
            return -1;
        }
    }
}
