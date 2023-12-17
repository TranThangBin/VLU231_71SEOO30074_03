using System;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class DiemBUS
    {
        public static void UseDiems(Action<IQueryable<Diem>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.Diems);
            }
        }

        public static void UpdateDiem(string maSv, string maHp, Diem diem)
        {
            using (var db = new QLDKHPEntities())
            {
                Diem grade = db.Diems.Find(maSv, maHp);
                if (grade == null)
                {
                    db.Diems.Add(
                        new Diem()
                        {
                            MaSinhVien = maSv,
                            MaHp = maHp,
                            DiemTrongLop = diem.DiemTrongLop,
                            DiemGiuaKy = diem.DiemGiuaKy,
                            DiemCuoiKy = diem.DiemCuoiKy,
                        }
                    );
                }
                else
                {
                    grade.DiemTrongLop = diem.DiemTrongLop;
                    grade.DiemGiuaKy = diem.DiemGiuaKy;
                    grade.DiemCuoiKy = diem.DiemCuoiKy;
                }
                db.SaveChanges();
            }
        }
    }
}
