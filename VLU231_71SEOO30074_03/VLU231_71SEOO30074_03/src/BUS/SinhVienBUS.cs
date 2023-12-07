namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class SinhVienBUS
    {
        public static void InsertSinhVien(NguoiDung sinhVien, string maKhoa)
        {
            SinhVien sv = new SinhVien() { MaKhoa = maKhoa, NguoiDung = sinhVien, };
            using (var db = new QLDKHPEntities())
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
            }
        }

        public static void UpdateSinhVien(string maSinhVien, NguoiDung sinhVienMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                SinhVien sv = db.SinhViens.Find(maSinhVien);
                if (sv == null)
                {
                    return;
                }
                NguoiDung sinhVien = sv.NguoiDung;
                sinhVien.TenTk = sinhVienMoi.TenTk;
                sinhVien.MatKhau = sinhVienMoi.MatKhau;
                sinhVien.HoTen = sinhVienMoi.HoTen;
                sinhVien.NgaySinh = sinhVienMoi.NgaySinh;
                sinhVien.QueQuan = sinhVienMoi.QueQuan;
                sinhVien.GioiTinh = sinhVienMoi.GioiTinh;
                sinhVien.DiaChi = sinhVienMoi.DiaChi;
                db.SaveChanges();
            }
        }

        public static void DeleteSinhVien(string maSinhVien)
        {
            using (var db = new QLDKHPEntities())
            {
                SinhVien sv = db.SinhViens.Find(maSinhVien);
                if (sv == null)
                {
                    return;
                }
                db.NguoiDungs.Remove(sv.NguoiDung);
                db.SaveChanges();
            }
        }
    }
}
