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
                case (byte)LoaiNguoiDung.GiangVien:
                case (byte)LoaiNguoiDung.SinhVien:
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
                case (byte)LoaiNguoiDung.GiangVien:
                    lblUser.Text = "Thông tin giảng viên";
                    lblMa.Text = "MSGV:";
                    txtKhoa.Text = AuthBUS.User.Khoa.Ten;
                    pnlKhoa.Visible =
                        dkdMenuItem.Visible =
                        tchpMenuItem.Visible =
                        tchpMenuItem.Visible =
                            true;
                    break;
                case (byte)LoaiNguoiDung.SinhVien:
                    lblUser.Text = "Thông tin sinh viên";
                    lblMa.Text = "MSSV:";
                    txtKhoa.Text = AuthBUS.User.Khoa.Ten;
                    pnlKhoa.Visible = dkhpMenuItem.Visible = tchpMenuItem.Visible = true;
                    break;
                default:
                    lblUser.Text = "Thông tin quản trị viên";
                    lblMa.Text = "MÃ ADMIN:";
                    qlmhMenuItem.Visible =
                        qlKhoaMenuItem.Visible =
                        qllhpMenuItem.Visible =
                        qlNgDMenuItem.Visible =
                        qldMenuItem.Visible =
                            true;
                    break;
            }
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void childForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }

        private void qlKhoaMenuItem_Click(object sender, EventArgs e)
        {
            FacultyManager facultyManager = new FacultyManager();
            facultyManager.FormClosing += childForm_FormClosing;
            Hide();
            facultyManager.Show();
        }

        private void qlNgDMenuItem_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.FormClosing += childForm_FormClosing;
            Hide();
            userManager.Show();
        }

        private void qlmhMenuItem_Click(object sender, EventArgs e)
        {
            SubjectManager subjectManager = new SubjectManager();
            subjectManager.FormClosing += childForm_FormClosing;
            Hide();
            subjectManager.Show();
        }

        private void qllhpMenuItem_Click(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            classManager.FormClosing += childForm_FormClosing;
            Hide();
            classManager.Show();
        }
    }
}
