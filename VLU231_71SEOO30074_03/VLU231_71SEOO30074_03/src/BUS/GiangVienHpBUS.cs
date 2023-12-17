using System;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class GiangVienHpBUS
    {
        public static void UseGiangVienHp(string maGv, Action<IQueryable<LopHp>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.LopHps.Where(lhp => lhp.NguoiDungs.Any(ngD => ngD.Ma == maGv)));
            }
        }

        public static void DangKyDayHocPhan(string maGv, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung giangVien = db.NguoiDungs.Find(maGv);
                LopHp lopHp = db.LopHps.Find(maHp);
                if (
                    lopHp.NguoiDungs.Any(
                        nguoiDung => nguoiDung.Loai == (byte)LoaiNguoiDung.GiangVien
                    )
                )
                {
                    return;
                }
                giangVien.LopHps.Add(lopHp);
                db.SaveChanges();
            }
        }

        public static void HuyDayHocPhan(string maGv, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung giangVien = db.NguoiDungs.Find(maGv);
                LopHp lopHp = db.LopHps.Find(maHp);
                giangVien.LopHps.Remove(lopHp);
                db.SaveChanges();
            }
        }
    }
}
