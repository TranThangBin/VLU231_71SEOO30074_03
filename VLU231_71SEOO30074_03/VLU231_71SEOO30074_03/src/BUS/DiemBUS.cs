using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class DiemBUS
    {
        public static void InsertDiem(string maSinhVien, string maHp)
        {
            Diem grade = new Diem() { MaSinhVien = maSinhVien, MaHp = maHp, };
            using (var db = new QLDKHPEntities())
            {
                db.Diems.Add(grade);
                db.SaveChanges();
            }
        }

        public static void UpdateDiem(Diem DiemMoi, string maSinhVien, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                Diem grade = db.Diems.SingleOrDefault(d => d.MaSinhVien == maSinhVien && d.MaHp == maHp);
                if (grade == null)
                {
                    return;
                }
                grade.DiemTrongLop = DiemMoi.DiemTrongLop;
                grade.DiemGiuaKy = DiemMoi.DiemGiuaKy;
                grade.DiemCuoiKy = DiemMoi.DiemCuoiKy;
                db.SaveChanges();
            }
        }

        public static void deleteDiem(string maSinhVien, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                Diem grade = db.Diems.SingleOrDefault(d => d.MaSinhVien == maSinhVien && d.MaHp == maHp);
                if (grade == null)
                {
                    return;
                }
                db.Diems.Remove(grade);
                db.SaveChanges();
            }
        }
    }
}