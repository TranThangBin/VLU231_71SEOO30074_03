using System;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class FacultyManager : Form
    {
        public FacultyManager()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            txtMaKhoa.Focus();
            txtMaKhoa.Clear();
            txtTenGoi.Clear();
            txtSdt.Clear();
            txtDiaDiemVp.Clear();
            txtMaKhoa.Enabled = true;
            dgvKhoa.ClearSelection();
        }

        private Khoa GetKhoa()
        {
            return new Khoa()
            {
                Ma = txtMaKhoa.Text.Trim(),
                Ten = txtTenGoi.Text.Trim(),
                Sdt = txtSdt.Text.Trim(),
                DiadiemVp = txtDiaDiemVp.Text.Trim(),
            };
        }

        private void dgvKhoa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count <= 0)
            {
                return;
            }
            Khoa selectedKhoa = (Khoa)dgvKhoa.SelectedRows[0].Cells["khoa"].Value;
            txtMaKhoa.Enabled = false;
            txtMaKhoa.Text = selectedKhoa.Ma;
            txtTenGoi.Text = selectedKhoa.Ten;
            txtSdt.Text = selectedKhoa.Sdt;
            txtDiaDiemVp.Text = selectedKhoa.DiadiemVp;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FacultyManager_Load(object sender, EventArgs e)
        {
            KhoaBUS.UseKhoas(khoas =>
            {
                foreach (Khoa khoa in khoas)
                {
                    dgvKhoa.Rows.Add(khoa);
                }
            });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Bạn muốn thêm khoa", "Xác nhận", MessageBoxButtons.YesNoCancel)
                != DialogResult.Yes
            )
            {
                return;
            }
            Khoa khoa = GetKhoa();
            Result<Khoa> result = KhoaBUS.InsertKhoa(khoa);
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Thêm khoa thành công");
            dgvKhoa.Rows.Add(result.Value);
            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn khoa để sửa");
                return;
            }
            if (
                MessageBox.Show("Bạn muốn sửa khoa", "Xác nhận", MessageBoxButtons.YesNoCancel)
                != DialogResult.Yes
            )
            {
                return;
            }
            Khoa selectedKhoa = (Khoa)dgvKhoa.SelectedRows[0].Cells["khoa"].Value;
            Khoa khoa = GetKhoa();
            Result<Khoa> result = KhoaBUS.UpdateKhoa(selectedKhoa.Ma, khoa);
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Sửa khoa thành công");
            int selectedIndex = dgvKhoa.SelectedRows[0].Index;
            dgvKhoa.Rows.RemoveAt(selectedIndex);
            dgvKhoa.Rows.Insert(selectedIndex, khoa);
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn khoa để xóa");
                return;
            }
            if (
                MessageBox.Show("Bạn muốn sửa xóa", "Xác nhận", MessageBoxButtons.YesNoCancel)
                != DialogResult.Yes
            )
            {
                return;
            }
            Khoa khoa = (Khoa)dgvKhoa.SelectedRows[0].Cells["khoa"].Value;
            Result<Khoa> result = KhoaBUS.DeleteKhoa(khoa.Ma);
            if (result.IsError())
            {
                MessageBox.Show(result.Error.Message);
                return;
            }
            MessageBox.Show("Xóa thành công");
            dgvKhoa.Rows.Remove(dgvKhoa.SelectedRows[0]);
            ClearInput();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvKhoa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Khoa khoa = (Khoa)dgvKhoa.Rows[e.RowIndex].Cells["khoa"].Value;
            dgvKhoa.Rows[e.RowIndex].SetValues(khoa, khoa.Ma, khoa.Ten, khoa.Sdt, khoa.DiadiemVp);
        }

        private void txtMaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
