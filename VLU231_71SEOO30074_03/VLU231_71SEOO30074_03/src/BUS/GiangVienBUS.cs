namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class GiangVienBUS
    {
        public static void InsertGiangVien(NguoiDung giangVien, string maKhoa)
        {
            GiangVien gv = new GiangVien() { MaKhoa = maKhoa, NguoiDung = giangVien, };
            using (var db = new QLDKHPEntities())
            {
                db.GiangViens.Add(gv);
                db.SaveChanges();
            }
        }

        public static void UpdateGiangVien(string maGiangVien, NguoiDung giangVienMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                GiangVien gv = db.GiangViens.Find(maGiangVien);
                if (gv == null)
                {
                    return;
                }
                NguoiDung giangVien = gv.NguoiDung;
                giangVien.TenTk = giangVienMoi.TenTk;
                giangVien.MatKhau = giangVienMoi.MatKhau;
                giangVien.HoTen = giangVienMoi.HoTen;
                giangVien.NgaySinh = giangVienMoi.NgaySinh;
                giangVien.QueQuan = giangVienMoi.QueQuan;
                giangVien.GioiTinh = giangVienMoi.GioiTinh;
                giangVien.DiaChi = giangVienMoi.DiaChi;
                db.SaveChanges();
            }
        }

        public static void DeleteGiangVien(string maGiangVien)
        {
            using (var db = new QLDKHPEntities())
            {
                GiangVien gv = db.GiangViens.Find(maGiangVien);
                if (gv == null)
                {
                    return;
                }
                db.NguoiDungs.Remove(gv.NguoiDung);
                db.SaveChanges();
            }
        }
    }
}
