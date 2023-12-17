using System;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class TeachingRegistration : Form
    {
        public TeachingRegistration()
        {
            InitializeComponent();
        }

        private void TeachingRegistration_Load(object sender, EventArgs e)
        {
            string maGv = string.Empty;
            string maKhoa = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maGv = user.Ma;
                maKhoa = user.MaKhoa;
            });
            MonHocBUS.UseMonHocs(monHocs =>
            {
                foreach (MonHoc monHoc in monHocs.Where(mh => mh.MaKhoa == maKhoa))
                {
                    cmbMonHoc.Items.Add(monHoc);
                }
            });
            GiangVienHpBUS.UseGiangVienHp(
                maGv,
                giangVienHps =>
                {
                    foreach (LopHp giangVienHp in giangVienHps)
                    {
                        dgvHp.Rows.Add(giangVienHp.MonHoc, giangVienHp);
                    }
                }
            );
            if (cmbMonHoc.Items.Count > 0)
            {
                cmbMonHoc.SelectedIndex = 0;
            }
        }

        private void dgvHp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHp.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string maGv = string.Empty;
                AuthBUS.UseUser(user =>
                {
                    maGv = user.Ma;
                });
                LopHp lopHp = (LopHp)dgvHp.Rows[e.RowIndex].Cells["lopHp"].Value;
                GiangVienHpBUS.HuyDayHocPhan(maGv, lopHp.Ma);
                dgvHp.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvHp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MonHoc monHoc = (MonHoc)dgvHp.Rows[e.RowIndex].Cells["monHoc"].Value;
            LopHp lopHp = (LopHp)dgvHp.Rows[e.RowIndex].Cells["lopHp"].Value;
            dgvHp.Rows[e.RowIndex].SetValues(monHoc, lopHp, monHoc.SoTc);
        }

        private void btnDk_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = (MonHoc)cmbMonHoc.SelectedItem;
            LopHp lopHp = (LopHp)cmbLopHp.SelectedItem;
            string maGv = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maGv = user.Ma;
            });
            GiangVienHpBUS.DangKyDayHocPhan(maGv, lopHp.Ma);
            dgvHp.Rows.Add(monHoc, lopHp);
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopHp.Items.Clear();
            cmbLopHp.Text = string.Empty;
            string maMh = ((MonHoc)cmbMonHoc.SelectedItem).Ma;
            LopHpBUS.UseLopHps(lopHps =>
            {
                foreach (LopHp lopHp in lopHps.Where(lhp => lhp.MaMonHoc == maMh))
                {
                    cmbLopHp.Items.Add(lopHp);
                }
            });
            if (cmbLopHp.Items.Count > 0)
            {
                cmbLopHp.SelectedIndex = 0;
            }
        }
    }
}
