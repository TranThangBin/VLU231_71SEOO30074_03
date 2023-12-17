using System;
using System.Linq;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class StudentClassLookUp : Form
    {
        public StudentClassLookUp()
        {
            InitializeComponent();
        }

        private void dgvHp_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void StudentClassLookUp_Load(object sender, EventArgs e)
        {
            string maSv = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maSv = user.Ma;
            });
            SinhVienHpBUS.UseSinhVienHps(sinhVienHps =>
            {
                foreach (
                    SinhvienHp sinhVienHp in sinhVienHps.Where(svhp => svhp.MaSinhVien == maSv)
                )
                {
                    NguoiDung giangVien = sinhVienHp.LopHp.NguoiDungs.FirstOrDefault(
                        nguoiDung => nguoiDung.Loai == (byte)LoaiNguoiDung.GiangVien
                    );
                    dgvHp.Rows.Add(
                        sinhVienHp.Diem,
                        giangVien.HoTen,
                        sinhVienHp.LopHp,
                        sinhVienHp.LopHp.MonHoc.SoTc
                    );
                }
            });
        }

        private void dgvHp_Enter(object sender, EventArgs e)
        {
            if (dgvHp.SelectedRows.Count < 0)
            {
                return;
            }
            Diem diem = (Diem)dgvHp.SelectedRows[0].Cells["diem"].Value;
            if (diem == null)
            {
                txtDiemQuaTrinh.Text = string.Empty;
                txtDiemGiuaKy.Text = string.Empty;
                txtDiemCuoiKy.Text = string.Empty;
                return;
            }
            txtDiemQuaTrinh.Text = diem.DiemTrongLop + "";
            txtDiemGiuaKy.Text = diem.DiemGiuaKy + "";
            txtDiemCuoiKy.Text = diem.DiemCuoiKy + "";
        }
    }
}
