﻿using System;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class SinhVienHpBUS
    {
        private const int DiemQuaMon = 5;

        public static void UseSinhVienHps(Action<IQueryable<SinhvienHp>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.SinhvienHps);
            }
        }

        public static void DangKyHocPhan(string maSv, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                LopHp lopHp = db.LopHps.Find(maHp);
                string maTienQuyet = lopHp.MonHoc.MonHoc2?.Ma;
                if (maTienQuyet != null)
                {
                    SinhvienHp hpTienQuyet = db.SinhvienHps.Find(maSv, maTienQuyet);
                    if (hpTienQuyet == null)
                    {
                        return;
                    }
                    if (
                        hpTienQuyet.Diem.DiemTrongLop < DiemQuaMon
                        || hpTienQuyet.Diem.DiemGiuaKy < DiemQuaMon
                        || hpTienQuyet.Diem.DiemCuoiKy < DiemQuaMon
                    )
                    {
                        return;
                    }
                }
                db.SinhvienHps.Add(new SinhvienHp() { MaSinhVien = maSv, MaHp = maHp, });
                db.SaveChanges();
            }
        }

        public static void HuyHocPhan(string maSv, string maHp)
        {
            using (var db = new QLDKHPEntities())
            {
                SinhvienHp sinhvienHp = db.SinhvienHps.Find(maSv, maHp);
                if (sinhvienHp == null)
                {
                    return;
                }
                db.SinhvienHps.Remove(sinhvienHp);
                db.SaveChanges();
            }
        }
    }
}
