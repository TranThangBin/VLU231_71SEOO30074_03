using System;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class LopHpBUS
    {
        public static void UseLopHps(Action<IQueryable<LopHp>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.LopHps);
            }
        }

        public static void InsertLopHp(LopHp lopHp)
        {
            using (var db = new QLDKHPEntities())
            {
                db.LopHps.Add(new LopHp() { Ma = lopHp.Ma, MaMonHoc = lopHp.MaMonHoc, });
                db.SaveChanges();
            }
        }

        public static void UpdateLopHp(string maLopHP, LopHp lopHpMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                LopHp lophp = db.LopHps.Find(maLopHP);
                if (lophp == null)
                {
                    return;
                }
                db.SaveChanges();
            }
        }

        public static void DeleteLopHp(string maLopHP)
        {
            using (var db = new QLDKHPEntities())
            {
                LopHp hp = db.LopHps.Find(maLopHP);
                if (hp == null)
                {
                    return;
                }
                db.LopHps.Remove(hp);
                db.SaveChanges();
            }
        }
    }
}
