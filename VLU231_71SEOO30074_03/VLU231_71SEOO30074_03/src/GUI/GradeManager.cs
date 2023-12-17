using System;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class GradeManager : Form
    {
        public GradeManager()
        {
            InitializeComponent();
        }

        private void GradeManager_Load(object sender, EventArgs e)
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

        private void dgvSv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NguoiDung sinhVien = (NguoiDung)dgvSv.Rows[e.RowIndex].Cells["sinhVien"].Value;
            dgvSv.Rows[e.RowIndex].SetValues(
                sinhVien,
                sinhVien.Ma,
                sinhVien.HoTen,
                sinhVien.NgaySinh,
                sinhVien.QueQuan,
                sinhVien.DiaChi
            );
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDung sinhVien = (NguoiDung)dgvSv.SelectedRows[0].Cells["sinhVien"].Value;
            LopHp lopHp = (LopHp)cmbLopHoc.SelectedItem;
            DiemBUS.UpdateDiem(
                sinhVien.Ma,
                lopHp.Ma,
                new Diem()
                {
                    DiemTrongLop = numDiemQuaTrinh.Value,
                    DiemGiuaKy = numDiemGiuaKy.Value,
                    DiemCuoiKy = numDiemCuoiKy.Value
                }
            );
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            numDiemQuaTrinh.Value = 0;
            numDiemGiuaKy.Value = 0;
            numDiemCuoiKy.Value = 0;
            string maKhoa = ((Khoa)cmbKhoa.SelectedItem).Ma;
            cmbMonHoc.Items.Clear();
            cmbMonHoc.Text = string.Empty;
            MonHocBUS.UseMonHocs(monHocs =>
            {
                foreach (MonHoc monHoc in monHocs.Where(mh => mh.MaKhoa == maKhoa))
                {
                    cmbMonHoc.Items.Add(monHoc);
                }
            });
            if (cmbMonHoc.Items.Count > 0)
            {
                cmbMonHoc.SelectedIndex = 0;
            }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            numDiemQuaTrinh.Value = 0;
            numDiemGiuaKy.Value = 0;
            numDiemCuoiKy.Value = 0;
            cmbLopHoc.SelectedIndex = -1;
            string maMonHoc = ((MonHoc)cmbMonHoc.SelectedItem).Ma;
            cmbLopHoc.Items.Clear();
            cmbLopHoc.Text = string.Empty;
            LopHpBUS.UseLopHps(lopHps =>
            {
                foreach (LopHp lopHp in lopHps.Where(lhp => lhp.MaMonHoc == maMonHoc))
                {
                    cmbLopHoc.Items.Add(lopHp);
                }
            });
            if (cmbLopHoc.Items.Count > 0)
            {
                cmbLopHoc.SelectedIndex = 0;
            }
        }

        private void cmbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            numDiemQuaTrinh.Value = 0;
            numDiemGiuaKy.Value = 0;
            numDiemCuoiKy.Value = 0;
            dgvSv.Rows.Clear();
            string maLopHp = ((LopHp)cmbLopHoc.SelectedItem)?.Ma;
            SinhVienHpBUS.UseSinhVienHps(sinhVienHps =>
            {
                foreach (SinhvienHp sinhVienHp in sinhVienHps.Where(svhp => svhp.MaHp == maLopHp))
                {
                    dgvSv.Rows.Add(sinhVienHp.NguoiDung);
                }
            });
        }

        private void dgvSv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSv.Rows.Count <= 0)
            {
                return;
            }
            NguoiDung sinhVien = (NguoiDung)dgvSv.Rows[e.RowIndex].Cells["sinhVien"].Value;
            DiemBUS.UseDiems(diems =>
            {
                Diem diem = diems.FirstOrDefault(d => d.MaSinhVien == sinhVien.Ma);
                if (diem == null)
                {
                    numDiemQuaTrinh.Value = 0;
                    numDiemGiuaKy.Value = 0;
                    numDiemCuoiKy.Value = 0;
                    return;
                }
                numDiemQuaTrinh.Value = (decimal)diem.DiemTrongLop;
                numDiemGiuaKy.Value = (decimal)diem.DiemGiuaKy;
                numDiemCuoiKy.Value = (decimal)diem.DiemCuoiKy;
            });
        }
    }
}
