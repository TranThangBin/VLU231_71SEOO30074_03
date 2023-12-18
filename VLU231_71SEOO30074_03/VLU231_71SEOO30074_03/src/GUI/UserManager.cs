using System;
using System.Linq;
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
            txtMk.Clear();
            txtTk.Enabled = false;
            txtMk.Enabled = false;
            btnTaoTk.Enabled = false;
            btnSuaTk.Enabled = false;
            btnXoaTk.Enabled = false;
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

        private void UserManager_Load(object sender, EventArgs e)
        {
            cmbDoiTuong.SelectedIndex = 0;
            KhoaBUS.UseKhoas(khoas =>
            {
                foreach (Khoa khoa in khoas)
                {
                    cmbKhoa.Items.Add(khoa);
                }
            });
            if (cmbKhoa.Items.Count > 0)
            {
                cmbKhoa.SelectedIndex = 0;
            }
        }

        private void btnThemNgD_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Bạn muốn thêm người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung nguoiDung = GetNguoiDung();
            Result<NguoiDung> result = NguoiDungBUS.InsertNguoiDung(
                nguoiDung,
                cmbDoiTuong_GetValue()
            );
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Thêm người dùng thành công");
            dgvNguoiDung.Rows.Add(result.Value);
            ClearInput();
        }

        private void btnSuaNgD_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn người dùng để sửa");
                return;
            }
            if (
                MessageBox.Show(
                    "Bạn muốn sửa người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung selectedNguoiDung = (NguoiDung)
                dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            NguoiDung nguoiDung = GetNguoiDung();
            Result<NguoiDung> result = NguoiDungBUS.UpdateNguoiDung(
                selectedNguoiDung.Ma,
                nguoiDung
            );
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Sửa người dùng thành công");
            int selectedIndex = dgvNguoiDung.SelectedRows[0].Index;
            dgvNguoiDung.Rows.RemoveAt(selectedIndex);
            dgvNguoiDung.Rows.Insert(selectedIndex, result.Value);
            ClearInput();
        }

        private void BtnXoaNgD_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn người dùng để xóa");
                return;
            }
            if (
                MessageBox.Show(
                    "Bạn muốn xóa người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            Result<NguoiDung> result = NguoiDungBUS.DeleteNguoiDung(nguoiDung.Ma);
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Xóa người dùng thành công");
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
            if (dgvNguoiDung.SelectedRows.Count <= 0)
            {
                return;
            }
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            txtMaSv.Enabled = false;
            txtMaSv.Text = nguoiDung.Ma;
            txtHoTen.Text = nguoiDung.HoTen;
            dtpNgaySinh.Value = nguoiDung.NgaySinh;
            cmbGioiTinh.Text = nguoiDung.GioiTinh ? "Nam" : "Nữ";
            txtQueQuan.Text = nguoiDung.QueQuan;
            txtDiaChi.Text = nguoiDung.DiaChi;
            txtTk.Enabled = true;
            txtMk.Enabled = true;
            btnTaoTk.Enabled = true;
            btnSuaTk.Enabled = true;
            btnXoaTk.Enabled = true;
            TaiKhoan taiKhoan = TaiKhoanBUS.GetTaiKhoan(nguoiDung.Ma);
            txtTk.Text = taiKhoan?.TenTk;
            txtMk.Text = taiKhoan?.MatKhau;
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Bạn muốn tạo tài khoản cho người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            Result<TaiKhoan> result = TaiKhoanBUS.InsertTaiKhoan(nguoiDung.Ma, GetTaiKhoan());
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Tạo tài khoản thành công");
        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Bạn muốn sửa tài khoản của người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            Result<TaiKhoan> result = TaiKhoanBUS.UpdateTaiKhoan(nguoiDung.Ma, GetTaiKhoan());
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Sửa tài khoản thành công");
        }

        private void btnXoaTk_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Bạn muốn xóa tài khoản của người dùng này",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel
                ) != DialogResult.Yes
            )
            {
                return;
            }
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].Cells["nguoiDung"].Value;
            Result<TaiKhoan> result = TaiKhoanBUS.DeleteTaiKhoan(nguoiDung.Ma);
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Xóa tài khoản thành công");
            txtTk.Clear();
            txtMk.Clear();
        }

        private void cmbDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNguoiDung_Load();
        }

        private void dgvNguoiDung_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NguoiDung nguoiDung = (NguoiDung)dgvNguoiDung.Rows[e.RowIndex].Cells["nguoiDung"].Value;
            dgvNguoiDung.Rows[e.RowIndex].SetValues(
                nguoiDung,
                nguoiDung.Ma,
                nguoiDung.HoTen,
                nguoiDung.NgaySinh,
                nguoiDung.GioiTinh ? "Nam" : "Nữ",
                nguoiDung.QueQuan,
                nguoiDung.DiaChi
            );
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNguoiDung_Load();
        }

        private void dgvNguoiDung_Load()
        {
            dgvNguoiDung.Rows.Clear();
            string maKhoa = ((Khoa)cmbKhoa.SelectedItem)?.Ma;
            if (maKhoa == null)
            {
                return;
            }
            NguoiDungBUS.UseNguoiDungs(
                cmbDoiTuong_GetValue(),
                (
                    nguoiDungs =>
                    {
                        foreach (
                            NguoiDung nguoiDung in nguoiDungs.Where(ngD => ngD.MaKhoa == maKhoa)
                        )
                        {
                            dgvNguoiDung.Rows.Add(nguoiDung);
                        }
                    }
                )
            );
        }

        private void txtHandleSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
