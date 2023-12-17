using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    public enum LoaiNguoiDung
    {
        GiangVien = 1,
        SinhVien = 2,
    }

    internal class NguoiDungBUS
    {
        public static List<NguoiDung> NguoiDungs(LoaiNguoiDung loaiNguoiDung)
        {
            using (var db = new QLDKHPEntities())
            {
                return db.NguoiDungs
                    .Include(sinhVien => sinhVien.Khoa)
                    .Include(sinhVien => sinhVien.TaiKhoan)
                    .Where(nguoiDung => nguoiDung.Loai == (byte)loaiNguoiDung)
                    .ToList();
            }
        }

        public static NguoiDung InsertNguoiDung(NguoiDung nguoiDung, LoaiNguoiDung loaiNguoiDung)
        {
            if (nguoiDung.Loai != (byte)loaiNguoiDung)
            {
                return null;
            }
            using (var db = new QLDKHPEntities())
            {
                NguoiDung ngD = db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
                return ngD;
            }
        }

        public static NguoiDung UpdateNguoiDung(
            string maNgD,
            NguoiDung nguoiDungMoi,
            LoaiNguoiDung loaiNguoiDung
        )
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung?.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                nguoiDung.HoTen = nguoiDungMoi.HoTen;
                nguoiDung.MaKhoa = nguoiDungMoi.MaKhoa;
                nguoiDung.NgaySinh = nguoiDungMoi.NgaySinh;
                nguoiDung.GioiTinh = nguoiDungMoi.GioiTinh;
                nguoiDung.QueQuan = nguoiDungMoi.QueQuan;
                nguoiDung.DiaChi = nguoiDungMoi.DiaChi;
                db.SaveChanges();
                return nguoiDung;
            }
        }

        public static NguoiDung DeleteNguoiDung(string maNgD, LoaiNguoiDung loaiNguoiDung)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung?.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                db.NguoiDungs.Remove(nguoiDung);
                db.SaveChanges();
                return nguoiDung;
            }
        }

        public static TaiKhoan GetTaiKhoanNguoiDung(string maNgD, LoaiNguoiDung loaiNguoiDung)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan tkNguoiDung = db.TaiKhoans.Find(maNgD);
                if (tkNguoiDung?.NguoiDung.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                return tkNguoiDung;
            }
        }

        public static TaiKhoan InsertTaiKhoanNguoiDung(
            string maNgD,
            TaiKhoan taiKhoan,
            LoaiNguoiDung loaiNguoiDung
        )
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung nguoiDung = db.NguoiDungs.Find(maNgD);
                if (nguoiDung?.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                nguoiDung.TaiKhoan = taiKhoan;
                db.SaveChanges();
                return nguoiDung.TaiKhoan;
            }
        }

        public static TaiKhoan UpdateTaiKhoanNguoiDung(
            string maNgD,
            TaiKhoan taiKhoanMoi,
            LoaiNguoiDung loaiNguoiDung
        )
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan?.NguoiDung.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                taiKhoan.TenTk = taiKhoanMoi.TenTk;
                taiKhoan.MatKhau = taiKhoanMoi.MatKhau;
                db.SaveChanges();
                return taiKhoan;
            }
        }

        public static TaiKhoan DeleteTaiKhoanNguoiDung(string maNgD, LoaiNguoiDung loaiNguoiDung)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan taiKhoan = db.TaiKhoans.Find(maNgD);
                if (taiKhoan?.NguoiDung.Loai != (byte)loaiNguoiDung)
                {
                    return null;
                }
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
                return taiKhoan;
            }
        }
    }
}
