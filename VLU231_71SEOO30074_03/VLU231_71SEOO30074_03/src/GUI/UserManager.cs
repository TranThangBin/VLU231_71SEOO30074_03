﻿using System;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            dgvNguoiDung.ClearSelection();
            txtTk.Clear();
            txtTk.Enabled = false;
            txtMk.Clear();
            txtMk.Enabled = false;
            txtMaSv.Enabled = true;
            txtMaSv.Clear();
            txtHoTen.Clear();
            cmbKhoa.SelectedItem = cmbKhoa.Items[0];
            dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.SelectedItem = cmbGioiTinh.Items[0];
            txtQueQuan.Clear();
            txtDiaChi.Clear();
        }

        private NguoiDung GetNguoiDung()
        {
            Khoa khoa = (Khoa)cmbKhoa.SelectedItem;
            return new NguoiDung()
            {
                Ma = txtMaSv.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                MaKhoa = khoa.Ma,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cmbGioiTinh.Text == "Nam",
                QueQuan = txtQueQuan.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                Khoa = khoa,
            };
        }

        private LoaiNguoiDung cmbDoiTuong_GetValue()
        {
            if (cmbDoiTuong.Text == "Giảng viên")
            {
                return LoaiNguoiDung.GiangVien;
            }
            return LoaiNguoiDung.SinhVien;
        }

        private TaiKhoan GetTaiKhoan()
        {
            return new TaiKhoan() { TenTk = txtTk.Text, MatKhau = txtMk.Text, };
        }

        private NguoiDung dgvNguoiDung_SelectedValue()
        {
            if (dgvNguoiDung.SelectedRows.Count <= 0)
            {
                return null;
            }
            DataGridViewCellCollection cells = dgvNguoiDung.SelectedRows[0].Cells;
            return new NguoiDung()
            {
                Ma = cells["maNgD"].Value + "",
                HoTen = cells["hoTen"].Value + "",
                Khoa = (Khoa)cells["khoa"].Value,
                NgaySinh = (DateTime)cells["ngaySinh"].Value,
                GioiTinh = cells["gioiTinh"].Value + "" == "Nam",
                QueQuan = cells["queQuan"].Value + "",
                DiaChi = cells["diaChi"].Value + "",
                Loai = (byte)cmbDoiTuong_GetValue(),
            };
        }

        private void StudenManager_Load(object sender, EventArgs e)
        {
            cmbDoiTuong.SelectedItem = cmbDoiTuong.Items[0];
            KhoaBUS.UseKhoas(khoas =>
            {
                foreach (Khoa khoa in khoas)
                {
                    cmbKhoa.Items.Add(khoa);
                }
            });
            cmbKhoa.SelectedItem = cmbKhoa.Items[0];
        }

        private void btnThemNgD_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = GetNguoiDung();
            NguoiDungBUS.InsertNguoiDung(nguoiDung, cmbDoiTuong_GetValue());
            dgvNguoiDung.Rows.Add(
                nguoiDung.Ma,
                nguoiDung.HoTen,
                nguoiDung.Khoa,
                nguoiDung.NgaySinh,
                nguoiDung.GioiTinh ? "Nam" : "Nữ",
                nguoiDung.QueQuan,
                nguoiDung.DiaChi
            );
            ClearInput();
        }

        private void btnSuaNgD_Click(object sender, EventArgs e)
        {
            NguoiDung selectedNguoiDung = dgvNguoiDung_SelectedValue();
            if (selectedNguoiDung == null)
            {
                return;
            }
            NguoiDung nguoiDung = GetNguoiDung();
            NguoiDungBUS.UpdateNguoiDung(selectedNguoiDung.Ma, nguoiDung);
            int selectedIndex = dgvNguoiDung.SelectedRows[0].Index;
            dgvNguoiDung.Rows.RemoveAt(selectedIndex);
            dgvNguoiDung.Rows.Insert(
                selectedIndex,
                nguoiDung.Ma,
                nguoiDung.HoTen,
                nguoiDung.Khoa,
                nguoiDung.NgaySinh,
                nguoiDung.GioiTinh ? "Nam" : "Nữ",
                nguoiDung.QueQuan,
                nguoiDung.DiaChi
            );
            ClearInput();
        }

        private void BtnXoaNgD_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = dgvNguoiDung_SelectedValue();
            if (nguoiDung == null)
            {
                return;
            }
            NguoiDungBUS.DeleteNguoiDung(nguoiDung.Ma);
            dgvNguoiDung.Rows.Remove(dgvNguoiDung.SelectedRows[0]);
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

        private void dgvNguoiDung_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            NguoiDung nguoiDung = dgvNguoiDung_SelectedValue();
            if (nguoiDung == null)
            {
                return;
            }
            txtMaSv.Enabled = false;
            txtMaSv.Text = nguoiDung.Ma;
            txtHoTen.Text = nguoiDung.HoTen;
            cmbKhoa.Text = nguoiDung.Khoa + "";
            dtpNgaySinh.Value = nguoiDung.NgaySinh;
            cmbGioiTinh.Text = nguoiDung.GioiTinh ? "Nam" : "Nữ";
            txtQueQuan.Text = nguoiDung.QueQuan;
            txtDiaChi.Text = nguoiDung.DiaChi;
            txtTk.Enabled = true;
            txtMk.Enabled = true;
            TaiKhoan taiKhoan = NguoiDungBUS.GetTaiKhoanNguoiDung(nguoiDung.Ma);
            if (taiKhoan != null)
            {
                txtTk.Text = taiKhoan.TenTk;
                txtMk.Text = taiKhoan.MatKhau;
            }
            else
            {
                txtTk.Text = string.Empty;
                txtMk.Text = string.Empty;
            }
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.InsertTaiKhoanNguoiDung(GetNguoiDung().Ma, GetTaiKhoan());
        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.UpdateTaiKhoanNguoiDung(GetNguoiDung().Ma, GetTaiKhoan());
        }

        private void btnXoaTk_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.DeleteTaiKhoanNguoiDung(GetNguoiDung().Ma);
            txtTk.Clear();
            txtMk.Clear();
        }

        private void cmbDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNguoiDung.Rows.Clear();
            NguoiDungBUS.UseNguoiDungs(
                cmbDoiTuong_GetValue(),
                (
                    nguoiDungs =>
                    {
                        foreach (NguoiDung nguoiDung in nguoiDungs)
                        {
                            dgvNguoiDung.Rows.Add(
                                nguoiDung.Ma,
                                nguoiDung.HoTen,
                                nguoiDung.Khoa,
                                nguoiDung.NgaySinh,
                                nguoiDung.GioiTinh ? "Nam" : "Nữ",
                                nguoiDung.QueQuan,
                                nguoiDung.DiaChi
                            );
                        }
                    }
                )
            );
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
