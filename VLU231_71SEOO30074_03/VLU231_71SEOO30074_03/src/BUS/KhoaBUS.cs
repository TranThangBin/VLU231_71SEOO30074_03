using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class KhoaBUS
    {
        public static List<Khoa> Khoas
        {
            get
            {
                using (var db = new QLDKHPEntities())
                {
                    List<Khoa> khoas = db.Khoas.ToList();
                    return khoas;
                }
            }
        }

        public static void InsertKhoa(Khoa khoa)
        {
            using (var db = new QLDKHPEntities())
            {
                db.Khoas.Add(khoa);
                db.SaveChanges();
            }
        }

        public static void UpdateKhoa(string maKhoa, Khoa khoaMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if (k == null)
                {
                    return;
                }
                k.Ten = khoaMoi.Ten;
                k.Sdt = khoaMoi.Sdt;
                k.DiadiemVp = khoaMoi.DiadiemVp;
                db.SaveChanges();
            }
        }

        public static void DeleteKhoa(string maKhoa)
        {
            using (var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if (k == null)
                {
                    return;
                }
                db.Khoas.Remove(k);
                db.SaveChanges();
            }
        }
    }
}
