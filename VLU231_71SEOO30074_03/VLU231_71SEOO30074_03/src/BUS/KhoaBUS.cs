using System;
using System.Data.Entity;

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
