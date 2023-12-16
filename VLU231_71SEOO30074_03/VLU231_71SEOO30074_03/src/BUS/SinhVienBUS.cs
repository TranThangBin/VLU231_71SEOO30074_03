using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class SinhVienBUS
    {
        public const byte MaLoai = 2;

        public static List<NguoiDung> SinhViens
        {
            get
            {
                using (var db = new QLDKHPEntities())
                {
                    return db.NguoiDungs
                        .Include(sinhVien => sinhVien.Khoa)
                        .Include(sinhVien => sinhVien.TaiKhoan)
                        .Where(nguoiDung => nguoiDung.Loai == MaLoai)
                        .ToList();
                }
            }
        }

        public static void InsertSinhVien(NguoiDung sinhVien)
        {
            if (sinhVien.Loai != MaLoai)
            {
                return;
            }
            using (var db = new QLDKHPEntities())
            {
                db.NguoiDungs.Add(sinhVien);
                db.SaveChanges();
            }
        }

        public static void UpdateSinhVien(string maSv, NguoiDung sinhVienMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null || sinhVien.Loai != MaLoai)
                {
                    return;
                }
                sinhVien.HoTen = sinhVienMoi.HoTen;
                sinhVien.MaKhoa = sinhVienMoi.MaKhoa;
                sinhVien.NgaySinh = sinhVienMoi.NgaySinh;
                sinhVien.GioiTinh = sinhVienMoi.GioiTinh;
                sinhVien.QueQuan = sinhVienMoi.QueQuan;
                sinhVien.DiaChi = sinhVienMoi.DiaChi;
                db.SaveChanges();
            }
        }

        public static void DeleteSinhVien(string maSv)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null || sinhVien.Loai != MaLoai)
                {
                    return;
                }
                db.NguoiDungs.Remove(sinhVien);
                db.SaveChanges();
            }
        }

        public static TaiKhoan GetTaiKhoanSinhVien(string maSv)
        {
            using (var db = new QLDKHPEntities())
            {
                TaiKhoan tkSinhVien = db.TaiKhoans.Find(maSv);
                if (tkSinhVien?.NguoiDung?.Loai != MaLoai)
                {
                    return null;
                }
                return tkSinhVien;
            }
        }

        public static void InsertTaiKhoanSinhVien(string maSv, TaiKhoan taiKhoan)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null || sinhVien.Loai != MaLoai)
                {
                    return;
                }
                sinhVien.TaiKhoan = taiKhoan;
                db.SaveChanges();
            }
        }

        public static void UpdateTaiKhoanSinhVien(string maSv, TaiKhoan taiKhoanMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null || sinhVien.Loai != MaLoai)
                {
                    return;
                }
                sinhVien.TaiKhoan.TenTk = taiKhoanMoi.TenTk;
                sinhVien.TaiKhoan.MatKhau = taiKhoanMoi.MatKhau;
                db.SaveChanges();
            }
        }

        public static void DeleteTaiKhoanSinhVien(string maSv)
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null || sinhVien.Loai != MaLoai)
                {
                    return;
                }
                db.TaiKhoans.Remove(sinhVien.TaiKhoan);
                db.SaveChanges();
            }
        }
    }
}
