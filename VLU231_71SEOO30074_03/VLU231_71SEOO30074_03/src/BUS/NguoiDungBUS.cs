using System.Linq;
using System;

namespace VLU231_71SEOO30074_03.src.BUS
{
    public enum LoaiNguoiDung
    {
        GiangVien = 1,
        SinhVien = 2,
    }

    internal class NguoiDungBUS
    {
        public static void UseNguoiDungs(
            LoaiNguoiDung loaiNguoiDung,
            Action<IQueryable<NguoiDung>> callback
        )
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.NguoiDungs.Where(nguoiDung => nguoiDung.Loai == (byte)loaiNguoiDung));
            }
        }

        public static void InsertNguoiDung(NguoiDung nguoiDung, LoaiNguoiDung loaiNguoiDung)
        {
            using (var db = new QLDKHPEntities())
            {
                db.NguoiDungs.Add(
                    new NguoiDung()
                    {
                        Ma = nguoiDung.Ma,
                        HoTen = nguoiDung.HoTen,
                        MaKhoa = nguoiDung.MaKhoa,
                        NgaySinh = nguoiDung.NgaySinh,
                        GioiTinh = nguoiDung.GioiTinh,
                        QueQuan = nguoiDung.QueQuan,
                        DiaChi = nguoiDung.DiaChi,
                        Loai = (byte)loaiNguoiDung,
                    }
                );
                db.SaveChanges();
            }
        }

        public static void UpdateNguoiDung(string maNgD, NguoiDung nguoiDungMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung?.Loai != nguoiDungMoi.Loai)
                {
                    return;
                }
                nguoiDung.HoTen = nguoiDungMoi.HoTen;
                nguoiDung.MaKhoa = nguoiDungMoi.MaKhoa;
                nguoiDung.NgaySinh = nguoiDungMoi.NgaySinh;
                nguoiDung.GioiTinh = nguoiDungMoi.GioiTinh;
                nguoiDung.QueQuan = nguoiDungMoi.QueQuan;
                nguoiDung.DiaChi = nguoiDungMoi.DiaChi;
                db.SaveChanges();
            }
        }

        public static void DeleteNguoiDung(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung == null)
                {
                    return;
                }
                db.NguoiDungs.Remove(nguoiDung);
                db.SaveChanges();
            }
        }

        public static TaiKhoan GetTaiKhoanNguoiDung(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                return db.TaiKhoans.Find(maNgD);
            }
        }

        public static void InsertTaiKhoanNguoiDung(string maNgD, TaiKhoan taiKhoan)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung == null)
                {
                    return;
                }
                nguoiDung.TaiKhoan = taiKhoan;
                db.SaveChanges();
            }
        }

        public static void UpdateTaiKhoanNguoiDung(string maNgD, TaiKhoan taiKhoanMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan == null)
                {
                    return;
                }
                taiKhoan.TenTk = taiKhoanMoi.TenTk;
                taiKhoan.MatKhau = taiKhoanMoi.MatKhau;
                db.SaveChanges();
            }
        }

        public static void DeleteTaiKhoanNguoiDung(string maNgD)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan == null)
                {
                    return;
                }
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
            }
        }
    }
}
