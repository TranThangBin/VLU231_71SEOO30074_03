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

        private Khoa dgvKhoa_SelectedValue()
        {
            if (dgvKhoa.SelectedRows.Count <= 0)
            {
                return null;
            }
            DataGridViewCellCollection cells = dgvKhoa.SelectedRows[0].Cells;
            return new Khoa()
            {
                Ma = cells["maKhoa"].Value + "",
                Ten = cells["tenGoi"].Value + "",
                Sdt = cells["sdt"].Value + "",
                DiadiemVp = cells["diaDiemVp"].Value + "",
            };
        }

        private void dgvKhoa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Khoa selectedKhoa = dgvKhoa_SelectedValue();
            if (selectedKhoa == null)
            {
                return;
            }
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
            foreach (Khoa khoa in KhoaBUS.Khoas)
            {
                dgvKhoa.Rows.Add(khoa.Ma, khoa.Ten, khoa.Sdt, khoa.DiadiemVp);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Khoa khoa = GetKhoa();
            KhoaBUS.InsertKhoa(khoa);
            dgvKhoa.Rows.Add(khoa.Ma, khoa.Ten, khoa.Sdt, khoa.DiadiemVp);
            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khoa selectedKhoa = dgvKhoa_SelectedValue();
            if (selectedKhoa == null)
            {
                return;
            }
            Khoa khoa = GetKhoa();
            KhoaBUS.UpdateKhoa(selectedKhoa.Ma, khoa);
            int selectedIndex = dgvKhoa.SelectedRows[0].Index;
            dgvKhoa.Rows.RemoveAt(selectedIndex);
            dgvKhoa.Rows.Insert(selectedIndex, khoa.Ma, khoa.Ten, khoa.Sdt, khoa.DiadiemVp);
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = dgvKhoa_SelectedValue();
            if (khoa == null)
            {
                return;
            }
            KhoaBUS.DeleteKhoa(khoa.Ma);
            dgvKhoa.Rows.Remove(dgvKhoa.SelectedRows[0]);
            ClearInput();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
