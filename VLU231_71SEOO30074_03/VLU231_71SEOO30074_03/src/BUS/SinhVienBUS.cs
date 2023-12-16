using System.Windows.Forms;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class SinhVienBUS
    {
        public const byte MaLoai = 2;

        private Control maSvCtrl;
        private Control maKhoaCtrl;
        private Control hoTenCtrl;
        private Control gioiTinhCtrl;
        private Control queQuanCtrl;
        private Control diaChiCtrl;

        private string maSv
        {
            get => maSvCtrl.Text.Trim();
        }
        private string maKhoa
        {
            get => maKhoaCtrl.Text.Trim();
        }
        private string hoTen
        {
            get => hoTenCtrl.Text.Trim();
        }
        private string gioiTinh
        {
            get => gioiTinhCtrl.Text.Trim();
        }
        private string queQuan
        {
            get => queQuanCtrl.Text.Trim();
        }
        private string diaChi
        {
            get => diaChiCtrl.Text.Trim();
        }

        public SinhVienBUS(
            Control maSvCtrl,
            Control maKhoaCtrl,
            Control hoTenCtrl,
            Control gioiTinhCtrl,
            Control queQuanCtrl,
            Control diaChiCtrl
        )
        {
            this.maSvCtrl = maSvCtrl;
            this.maKhoaCtrl = maKhoaCtrl;
            this.hoTenCtrl = hoTenCtrl;
            this.gioiTinhCtrl = gioiTinhCtrl;
            this.queQuanCtrl = queQuanCtrl;
            this.diaChiCtrl = diaChiCtrl;
        }

        public void InsertSinhVien()
        {
            string gioiTinh = this.gioiTinh;
            if (gioiTinh != "Nam" && gioiTinh != "Nữ")
            {
                return;
            }
            using (var db = new QLDKHPEntities())
            {
                db.NguoiDungs.Add(
                    new NguoiDung()
                    {
                        Ma = maSv,
                        MaKhoa = maKhoa,
                        HoTen = hoTen,
                        GioiTinh = gioiTinh == "Nam",
                        QueQuan = queQuan,
                        DiaChi = diaChi,
                        Loai = MaLoai,
                    }
                );
                db.SaveChanges();
            }
        }

        public void UpdateSinhVien()
        {
            string gioiTinh = this.gioiTinh;
            if (gioiTinh != "Nam" && gioiTinh != "Nữ")
            {
                return;
            }
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSvCtrl.Text);
                if (sinhVien == null)
                {
                    return;
                }
                sinhVien.HoTen = hoTen;
                sinhVien.GioiTinh = gioiTinh == "Nam";
                sinhVien.QueQuan = queQuan;
                sinhVien.DiaChi = diaChi;
                db.SaveChanges();
            }
        }

        public void DeleteSinhVien()
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung sinhVien = db.NguoiDungs.Find(maSv);
                if (sinhVien == null)
                {
                    return;
                }
                db.NguoiDungs.Remove(sinhVien);
                db.SaveChanges();
            }
        }
    }
}
