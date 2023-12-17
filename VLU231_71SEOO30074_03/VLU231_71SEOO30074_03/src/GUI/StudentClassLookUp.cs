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

        private void dgvHp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Diem diem = (Diem)dgvHp.Rows[e.RowIndex].Cells["diem"].Value;
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

        private void StudentClassLookUp_Load(object sender, EventArgs e)
        {
            string maSv = string.Empty;
            AuthBUS.UseUser(user =>
            {
                maSv = user.Ma;
            });
            SinhVienHpBUS.UseSinhVienHps(
                maSv,
                sinhVienHps =>
                {
                    foreach (SinhvienHp svhp in sinhVienHps)
                    {
                        NguoiDung giangVien = svhp.LopHp.NguoiDungs.FirstOrDefault(
                            nguoiDung => nguoiDung.Loai == (byte)LoaiNguoiDung.GiangVien
                        );
                        dgvHp.Rows.Add(
                            svhp.Diem,
                            giangVien.HoTen,
                            svhp.LopHp,
                            svhp.LopHp.MonHoc.SoTc
                        );
                    }
                }
            );
        }
    }
}
