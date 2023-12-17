using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class ClassManager : Form
    {
        public ClassManager()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            dgvLopHp.ClearSelection();
            txtMaLop.Enabled = true;
            txtMaLop.Clear();
        }

        public LopHp GetLopHp()
        {
            MonHoc monHoc = (MonHoc)cmbMh.SelectedItem;
            monHoc.Khoa = (Khoa)cmbKhoa.SelectedItem;
            return new LopHp()
            {
                Ma = txtMaLop.Text.Trim(),
                MaMonHoc = monHoc.Ma,
                MonHoc = monHoc,
            };
        }

        private void ClassManager_Load(object sender, EventArgs e)
        {
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

        private void dgvLopHp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow currentRow = dgvLopHp.Rows[e.RowIndex];
            LopHp lop = (LopHp)currentRow.Cells["refer"].Value;
            currentRow.SetValues(lop, lop.Ma, lop.MonHoc, lop.MonHoc.Khoa);
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInput();
            Khoa khoa = (Khoa)cmbKhoa.SelectedItem;
            cmbMh.Items.Clear();
            KhoaBUS.UseKhoas(khoas =>
            {
                khoa = khoas.Find(khoa.Ma);
                foreach (MonHoc monHoc in khoa.MonHocs)
                {
                    cmbMh.Items.Add(monHoc);
                }
            });
            if (cmbMh.Items.Count > 0)
            {
                cmbMh.SelectedIndex = 0;
            }
        }

        private void cmbMh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInput();
            MonHoc monHoc = (MonHoc)cmbMh.SelectedItem;
            dgvLopHp.Rows.Clear();
            LopHpBUS.UseLopHps(lopHps =>
            {
                foreach (LopHp lopHp in lopHps.Where(lhp => lhp.MaMonHoc == monHoc.Ma))
                {
                    dgvLopHp.Rows.Add(lopHp);
                }
            });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHp lopHp = GetLopHp();
            LopHpBUS.InsertLopHp(lopHp);
            dgvLopHp.Rows.Add(lopHp);
            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopHp.SelectedRows.Count <= 0)
            {
                return;
            }
            string maLop = dgvLopHp.SelectedRows[0].Cells["maLop"].Value + "";
            LopHp lopHp = GetLopHp();
            LopHpBUS.UpdateLopHp(maLop, lopHp);
            int rowIndex = dgvLopHp.SelectedRows[0].Index;
            dgvLopHp.Rows.RemoveAt(rowIndex);
            dgvLopHp.Rows.Insert(rowIndex, lopHp);
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLopHp.SelectedRows.Count <= 0)
            {
                return;
            }
            LopHp lopHp = (LopHp)dgvLopHp.SelectedRows[0].Cells["refer"].Value;
            LopHpBUS.DeleteLopHp(lopHp.Ma);
            dgvLopHp.Rows.Remove(dgvLopHp.SelectedRows[0]);
            ClearInput();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvLopHp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtMaLop.Text = dgvLopHp.Rows[e.RowIndex].Cells["maLop"].Value + "";
            txtMaLop.Enabled = false;
        }
    }
}
