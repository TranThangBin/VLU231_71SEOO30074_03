using System;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (!AuthBUS.IsAuthenticate())
            {
                Close();
                return;
            }
            switch (AuthBUS.User.Loai)
            {
                case GiangVienBUS.MaLoai:
                case SinhVienBUS.MaLoai:
                default:
                    txtMa.Text = AuthBUS.User.Ma;
                    txtHoTen.Text = AuthBUS.User.HoTen;
                    txtQueQuan.Text = AuthBUS.User.QueQuan;
                    txtDiaChi.Text = AuthBUS.User.DiaChi;
                    txtGioiTinh.Text = AuthBUS.User.GioiTinh ? "Nam" : "Nữ";
                    break;
            }
            switch (AuthBUS.User.Loai)
            {
                case 1:
                    lblUser.Text = "Thông tin giảng viên";
                    lblMa.Text = "MSGV:";
                    txtKhoa.Text = AuthBUS.User.Khoa.Ten;
                    pnlKhoa.Visible = dkhpMenuItem.Visible = tchpMenuItem.Visible = true;
                    break;
                case 2:
                    lblUser.Text = "Thông tin sinh viên";
                    lblMa.Text = "MSSV:";
                    txtKhoa.Text = AuthBUS.User.Khoa.Ten;
                    pnlKhoa.Visible = dkldMenuItem.Visible = true;
                    break;
                default:
                    lblUser.Text = "Thông tin quản trị viên";
                    lblMa.Text = "MÃ ADMIN:";
                    qlmhMenuItem.Visible =
                        qlKhoaMenuItem.Visible =
                        qllhpMenuItem.Visible =
                        qlsvMenuItem.Visible =
                        qlgvMenuItem.Visible =
                        qldMenuItem.Visible =
                            true;
                    break;
            }
        }

        private void qlKhoaMenuItem_Click(object sender, EventArgs e)
        {
            FacultyManager facultyManager = new FacultyManager();
            facultyManager.FormClosing += childForm_FormClosing;
            Hide();
            facultyManager.Show();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void childForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }
    }
}
