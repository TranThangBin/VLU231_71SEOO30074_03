using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class ClassRegistration : Form
    {
        public ClassRegistration()
        {
            InitializeComponent();
        }

        private void ClassRegistration_Load(object sender, System.EventArgs e)
        {
            string maSv = string.Empty;
            string maKhoa = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maSv = user.Ma;
                maKhoa = user.MaKhoa;
            });
            MonHocBUS.UseMonHocs(monHocs =>
            {
                foreach (MonHoc monHoc in monHocs.Where(mh => mh.MaKhoa == maKhoa))
                {
                    cmbMonHoc.Items.Add(monHoc);
                }
            });
            SinhVienHpBUS.UseSinhVienHps(sinhVienLopHps =>
            {
                foreach (
                    SinhvienHp sinhvienHp in sinhVienLopHps.Where(svhp => svhp.MaSinhVien == maSv)
                )
                {
                    dgvKqDk.Rows.Add(sinhvienHp.LopHp.MonHoc, sinhvienHp.LopHp);
                }
            });
            if (cmbMonHoc.Items.Count > 0)
            {
                cmbMonHoc.SelectedIndex = 0;
            }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void dgvKqDk_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow currentRow = dgvKqDk.Rows[e.RowIndex];
            MonHoc monHoc = (MonHoc)currentRow.Cells["monHoc"].Value;
            LopHp lopHp = (LopHp)currentRow.Cells["lopHp"].Value;
            currentRow.SetValues(monHoc, lopHp, monHoc.SoTc);
        }

        private void btnDangKy_Click(object sender, System.EventArgs e)
        {
            LopHp lopHp = (LopHp)cmbLopHp.SelectedItem;
            MonHoc monHoc = (MonHoc)cmbMonHoc.SelectedItem;
            string maSv = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maSv = user.Ma;
            });
            SinhVienHpBUS.DangKyHocPhan(maSv, lopHp.Ma);
            dgvKqDk.Rows.Add(monHoc, lopHp);
        }

        private void dgvKqDk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKqDk.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string maSv = string.Empty;
                AuthBUS.UseUser(user =>
                {
                    maSv = user.Ma;
                });
                MonHoc monHoc = (MonHoc)dgvKqDk.Rows[e.RowIndex].Cells["monHoc"].Value;
                LopHp lopHp = (LopHp)dgvKqDk.Rows[e.RowIndex].Cells["lopHp"].Value;
                SinhVienHpBUS.HuyHocPhan(maSv, lopHp.Ma);
                dgvKqDk.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
