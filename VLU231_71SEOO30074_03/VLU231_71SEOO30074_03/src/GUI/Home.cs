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
            AuthBUS.UseUser(user =>
            {
                switch (user.Loai)
                {
                    case (byte)LoaiNguoiDung.GiangVien:
                    case (byte)LoaiNguoiDung.SinhVien:
                    default:
                        txtMa.Text = user.Ma;
                        txtHoTen.Text = user.HoTen;
                        txtQueQuan.Text = user.QueQuan;
                        txtDiaChi.Text = user.DiaChi;
                        txtGioiTinh.Text = user.GioiTinh ? "Nam" : "Nữ";
                        break;
                }
                switch (user.Loai)
                {
                    case (byte)LoaiNguoiDung.GiangVien:
                        lblUser.Text = "Thông tin giảng viên";
                        lblMa.Text = "MSGV:";
                        txtKhoa.Text = user.Khoa.Ten;
                        pnlKhoa.Visible =
                            dkdMenuItem.Visible =
                            tchpGvMenuItem.Visible =
                            tchpGvMenuItem.Visible =
                                true;
                        break;
                    case (byte)LoaiNguoiDung.SinhVien:
                        lblUser.Text = "Thông tin sinh viên";
                        lblMa.Text = "MSSV:";
                        txtKhoa.Text = user.Khoa.Ten;
                        pnlKhoa.Visible = dkhpMenuItem.Visible = tchpSvMenuItem.Visible = true;
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
            });
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

        private void qldMenuItem_Click(object sender, EventArgs e)
        {
            GradeManager gradeManager = new GradeManager();
            gradeManager.FormClosing += childForm_FormClosing;
            Hide();
            gradeManager.Show();
        }

        private void dkhpMenuItem_Click(object sender, EventArgs e)
        {
            ClassRegistration classRegistration = new ClassRegistration();
            classRegistration.FormClosing += childForm_FormClosing;
            Hide();
            classRegistration.Show();
        }

        private void dkdMenuItem_Click(object sender, EventArgs e)
        {
            TeachingRegistration teachingRegistration = new TeachingRegistration();
            teachingRegistration.FormClosing += childForm_FormClosing;
            Hide();
            teachingRegistration.Show();
        }

        private void tchpSvMenuItem_Click(object sender, EventArgs e)
        {
            StudentClassLookUp studentClassLookUp = new StudentClassLookUp();
            studentClassLookUp.FormClosing += childForm_FormClosing;
            Hide();
            studentClassLookUp.Show();
        }
    }
}
