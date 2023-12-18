using System;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class LecturerClassLookUp : Form
    {
        public LecturerClassLookUp()
        {
            InitializeComponent();
        }

        private void LecturerClassLookUp_Load(object sender, EventArgs e)
        {
            AuthBUS.UseUser(user =>
            {
                foreach (LopHp lopHp in user.LopHps)
                {
                    dgvHp.Rows.Add(lopHp, lopHp.MonHoc.SoTc);
                }
            });
        }

        private void dgvHp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHp.SelectedRows.Count <= 0)
            {
                return;
            }
            dgvSv.Rows.Clear();
            string maLop = ((LopHp)dgvHp.SelectedRows[0].Cells["lopHp"].Value).Ma;
            SinhVienHpBUS.UseSinhVienHps(sinhVienHps =>
            {
                foreach (SinhvienHp sinhVienHp in sinhVienHps.Where(svhp => svhp.MaHp == maLop))
                {
                    dgvSv.Rows.Add(sinhVienHp.NguoiDung);
                }
            });
        }

        private void dgvSv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            NguoiDung sinhVien = (NguoiDung)dgvSv.Rows[e.RowIndex].Cells["sinhVien"].Value;
            dgvSv.Rows[e.RowIndex].SetValues(
                sinhVien,
                sinhVien.Ma,
                sinhVien.HoTen,
                sinhVien.Khoa,
                sinhVien.NgaySinh,
                sinhVien.QueQuan,
                sinhVien.DiaChi
            );
        }
    }
}
