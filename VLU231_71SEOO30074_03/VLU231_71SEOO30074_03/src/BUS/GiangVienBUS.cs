using System.Windows.Forms;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class GiangVienBUS
    {
        public const byte MaLoai = 1;

        private Control maGvCtrl;
        private Control maKhoaCtrl;
        private Control hoTenCtrl;
        private Control gioiTinhCtrl;
        private Control quequanCtrl;
        private Control diaChiCtrl;

        private string maGv
        {
            get => maGvCtrl.Text.Trim();
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
            get => quequanCtrl.Text.Trim();
        }
        private string diaChi
        {
            get => diaChiCtrl.Text.Trim();
        }

        public GiangVienBUS(
            Control maGvCtrl,
            Control maKhoaCtrl,
            Control hoTenCtrl,
            Control gioiTinhCtrl,
            Control diaChiCtrl
        )
        {
            this.maGvCtrl = maGvCtrl;
            this.maKhoaCtrl = maKhoaCtrl;
            this.hoTenCtrl = hoTenCtrl;
            this.gioiTinhCtrl = gioiTinhCtrl;
            this.diaChiCtrl = diaChiCtrl;
        }

        public void InsertGiangVien()
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
                        Ma = maGv,
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

        public void UpdateGiangVien()
        {
            string gioiTinh = this.gioiTinh;
            if (gioiTinh != "Nam" && gioiTinh != "Nữ")
            {
                return;
            }
            using (var db = new QLDKHPEntities())
            {
                NguoiDung giangVien = db.NguoiDungs.Find(maGvCtrl.Text);
                if (giangVien == null)
                {
                    return;
                }
                giangVien.HoTen = hoTen;
                giangVien.GioiTinh = gioiTinh == "Nam";
                giangVien.QueQuan = queQuan;
                giangVien.DiaChi = diaChi;
                db.SaveChanges();
            }
        }

        public void DeleteGiangVien()
        {
            using (var db = new QLDKHPEntities())
            {
                NguoiDung giangVien = db.NguoiDungs.Find(maGv);
                if (giangVien == null)
                {
                    return;
                }
                db.NguoiDungs.Remove(giangVien);
                db.SaveChanges();
            }
        }
    }
}
