using System;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class StudenManager : Form
    {
        public StudenManager()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            dgvSinhVien.ClearSelection();
            txtTk.Clear();
            txtTk.Enabled = false;
            txtMk.Clear();
            txtMk.Enabled = false;
            txtMaSv.Enabled = true;
            txtMaSv.Clear();
            txtHoTen.Clear();
            cmbKhoa.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.Text = string.Empty;
            txtQueQuan.Clear();
            txtDiaChi.Clear();
        }

        private NguoiDung GetSinhVien()
        {
            Khoa khoa = (Khoa)cmbKhoa.SelectedItem;
            return new NguoiDung()
            {
                Ma = txtMaSv.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Khoa = khoa,
                MaKhoa = khoa.Ma,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cmbGioiTinh.Text == "Nam",
                QueQuan = txtQueQuan.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                Loai = SinhVienBUS.MaLoai,
            };
        }

        private TaiKhoan GetTaiKhoan()
        {
            return new TaiKhoan() { TenTk = txtTk.Text, MatKhau = txtMk.Text, };
        }

        private NguoiDung dgvSinhVien_SelectedValue()
        {
            if (dgvSinhVien.SelectedRows.Count <= 0)
            {
                return null;
            }
            DataGridViewCellCollection cells = dgvSinhVien.SelectedRows[0].Cells;
            return new NguoiDung()
            {
                Ma = cells["maSv"].Value + "",
                HoTen = cells["hoTen"].Value + "",
                Khoa = (Khoa)cells["khoa"].Value,
                NgaySinh = (DateTime)cells["ngaySinh"].Value,
                GioiTinh = cells["gioiTinh"].Value + "" == "Nam",
                QueQuan = cells["queQuan"].Value + "",
                DiaChi = cells["diaChi"].Value + "",
                Loai = SinhVienBUS.MaLoai,
            };
        }

        private void StudenManager_Load(object sender, EventArgs e)
        {
            foreach (NguoiDung sinhVien in SinhVienBUS.SinhViens)
            {
                dgvSinhVien.Rows.Add(
                    sinhVien.Ma,
                    sinhVien.HoTen,
                    sinhVien.Khoa,
                    sinhVien.NgaySinh,
                    sinhVien.GioiTinh ? "Nam" : "Nữ",
                    sinhVien.QueQuan,
                    sinhVien.DiaChi
                );
            }
            foreach (Khoa khoa in KhoaBUS.Khoas)
            {
                cmbKhoa.Items.Add(khoa);
            }
        }

        private void btnThemSv_Click(object sender, EventArgs e)
        {
            NguoiDung sinhVien = GetSinhVien();
            SinhVienBUS.InsertSinhVien(sinhVien);
            dgvSinhVien.Rows.Add(
                sinhVien.Ma,
                sinhVien.HoTen,
                sinhVien.Khoa,
                sinhVien.NgaySinh,
                sinhVien.GioiTinh ? "Nam" : "Nữ",
                sinhVien.QueQuan,
                sinhVien.DiaChi
            );
            ClearInput();
        }

        private void btnSuaSv_Click(object sender, EventArgs e)
        {
            NguoiDung selectedSinhVien = dgvSinhVien_SelectedValue();
            if (selectedSinhVien == null)
            {
                return;
            }
            NguoiDung sinhVien = GetSinhVien();
            SinhVienBUS.UpdateSinhVien(selectedSinhVien.Ma, sinhVien);
            int selectedIndex = dgvSinhVien.SelectedRows[0].Index;
            dgvSinhVien.Rows.RemoveAt(selectedIndex);
            dgvSinhVien.Rows.Insert(
                selectedIndex,
                sinhVien.Ma,
                sinhVien.HoTen,
                sinhVien.Khoa,
                sinhVien.NgaySinh,
                sinhVien.GioiTinh ? "Nam" : "Nữ",
                sinhVien.QueQuan,
                sinhVien.DiaChi
            );
            ClearInput();
        }

        private void BtnXoaSv_Click(object sender, EventArgs e)
        {
            NguoiDung sinhVien = dgvSinhVien_SelectedValue();
            if (sinhVien == null)
            {
                return;
            }
            SinhVienBUS.DeleteSinhVien(sinhVien.Ma);
            dgvSinhVien.Rows.Remove(dgvSinhVien.SelectedRows[0]);
            ClearInput();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void rdBtnShowPw_Click(object sender, EventArgs e)
        {
            rdBtnShowPw.Checked = !rdBtnShowPw.Checked;
            txtMk.PasswordChar = txtMk.PasswordChar == '*' ? '\0' : '*';
        }

        private void dgvSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            NguoiDung sinhVien = dgvSinhVien_SelectedValue();
            if (sinhVien == null)
            {
                return;
            }
            txtMaSv.Enabled = false;
            txtMaSv.Text = sinhVien.Ma;
            txtHoTen.Text = sinhVien.HoTen;
            cmbKhoa.Text = sinhVien.Khoa + "";
            dtpNgaySinh.Value = sinhVien.NgaySinh;
            cmbGioiTinh.Text = sinhVien.GioiTinh ? "Nam" : "Nữ";
            txtQueQuan.Text = sinhVien.QueQuan;
            txtDiaChi.Text = sinhVien.DiaChi;
            txtTk.Enabled = true;
            txtMk.Enabled = true;
            TaiKhoan taiKhoan = SinhVienBUS.GetTaiKhoanSinhVien(sinhVien.Ma);
            if (taiKhoan != null)
            {
                txtTk.Text = taiKhoan.TenTk;
                txtMk.Text = taiKhoan.MatKhau;
            }
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            SinhVienBUS.InsertTaiKhoanSinhVien(GetSinhVien().Ma, GetTaiKhoan());
        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            SinhVienBUS.UpdateTaiKhoanSinhVien(GetSinhVien().Ma, GetTaiKhoan());
        }

        private void btnXoaTk_Click(object sender, EventArgs e)
        {
            SinhVienBUS.DeleteTaiKhoanSinhVien(GetSinhVien().Ma);
            txtTk.Clear();
            txtMk.Clear();
        }
    }
}
