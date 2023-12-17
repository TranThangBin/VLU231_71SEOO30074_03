using System;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class SubjectManager : Form
    {
        public SubjectManager()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            dgvMonHoc.ClearSelection();
            txtMaMH.Enabled = true;
            txtMaMH.Clear();
            txtTenMH.Clear();
            if (cmbTienQuyet.Items.Count > 0)
            {
                cmbTienQuyet.SelectedIndex = 0;
            }
            numSoTc.Value = numSoTc.Minimum;
        }

        private void SubjectManager_Load(object sender, EventArgs e)
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

        private MonHoc GetMonHoc()
        {
            Khoa khoa = (Khoa)cmbKhoa.SelectedItem;
            MonHoc tienQuyet = (MonHoc)cmbTienQuyet.SelectedItem;
            return new MonHoc()
            {
                Ma = txtMaMH.Text.Trim(),
                Ten = txtTenMH.Text.Trim(),
                MaKhoa = khoa.Ma,
                MaTienQuyet = tienQuyet?.Ma,
                SoTc = (byte)numSoTc.Value,
                Khoa = khoa,
                MonHoc2 = tienQuyet,
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = GetMonHoc();
            MonHocBUS.InsertMonHoc(monHoc);
            dgvMonHoc.Rows.Add(monHoc.Ma, monHoc.Ten, monHoc.Khoa, monHoc.MonHoc2, monHoc.SoTc);
            cmbTienQuyet.Items.Add(monHoc);
            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc selectedMonHoc = dgvMonHoc_SelectedValue();
            if (selectedMonHoc == null)
            {
                return;
            }
            MonHoc monHoc = GetMonHoc();
            MonHocBUS.UpdateMonHoc(selectedMonHoc.Ma, monHoc);
            int selectedIndex = dgvMonHoc.SelectedRows[0].Index;
            dgvMonHoc.Rows.RemoveAt(selectedIndex);
            dgvMonHoc.Rows.Insert(
                selectedIndex,
                monHoc.Ma,
                monHoc.Ten,
                monHoc.Khoa,
                monHoc.MonHoc2,
                monHoc.SoTc
            );
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonHoc selectedMonHoc = dgvMonHoc_SelectedValue();
            if (selectedMonHoc == null)
            {
                return;
            }
            MonHocBUS.DeleteMonHoc(selectedMonHoc.Ma);
            dgvMonHoc.Rows.Remove(dgvMonHoc.SelectedRows[0]);
            cmbTienQuyet.Items.Remove(selectedMonHoc);
            cmbTienQuyet.Items.Add(selectedMonHoc.MonHoc2);
            ClearInput();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvMonHoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MonHoc selectedMonHoc = dgvMonHoc_SelectedValue();
            if (selectedMonHoc == null)
            {
                return;
            }
            txtMaMH.Enabled = false;
            txtMaMH.Text = selectedMonHoc.Ma;
            txtTenMH.Text = selectedMonHoc.Ten;
            cmbKhoa.SelectedItem = selectedMonHoc.Khoa;
            cmbTienQuyet.SelectedItem = selectedMonHoc.MonHoc2;
            numSoTc.Value = selectedMonHoc.SoTc;
        }

        private MonHoc dgvMonHoc_SelectedValue()
        {
            if (dgvMonHoc.SelectedRows.Count <= 0)
            {
                return null;
            }
            DataGridViewCellCollection cells = dgvMonHoc.SelectedRows[0].Cells;
            return new MonHoc()
            {
                Ma = cells["maMh"].Value + "",
                Ten = cells["tenMh"].Value + "",
                Khoa = (Khoa)cells["khoa"].Value,
                MonHoc2 = (MonHoc)cells["monTienQuyet"].Value,
                SoTc = (byte)cells["soTc"].Value,
            };
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTienQuyet.Items.Clear();
            dgvMonHoc.Rows.Clear();
            ClearInput();
            MonHocBUS.UseMonHocs(
                (monHocs) =>
                {
                    string maKhoa = ((Khoa)cmbKhoa.SelectedItem).Ma;
                    foreach (MonHoc monHoc in monHocs.Where(mh => mh.MaKhoa == maKhoa))
                    {
                        dgvMonHoc.Rows.Add(
                            monHoc.Ma,
                            monHoc.Ten,
                            monHoc.Khoa,
                            monHoc.MonHoc2,
                            monHoc.SoTc
                        );
                        cmbTienQuyet.Items.Add(monHoc);
                    }
                }
            );
        }

        private void dgvMonHoc_Leave(object sender, EventArgs e) { }
    }
}
