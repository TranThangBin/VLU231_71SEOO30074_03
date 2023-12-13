using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class LopHpBUS
    {
        public static void InsertLopHp(string maMonHoc)
        {
            LopHp lophp = new LopHp() { MaMonHoc = maMonHoc };
            using (var db = new QLDKHPEntities())
            {
                db.LopHps.Add(lophp);
                db.SaveChanges();
            }
        }

        public static void updateLopHp(string maLopHP, LopHp lopHpMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                LopHp lophp = db.LopHps.Find(maLopHP);
                if (lophp == null)
                {
                    return;
                }
                lophp.Ma = lopHpMoi.Ma;
                db.SaveChanges();
            }
        }

        public static void deleteLopHp(string maLopHP)
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