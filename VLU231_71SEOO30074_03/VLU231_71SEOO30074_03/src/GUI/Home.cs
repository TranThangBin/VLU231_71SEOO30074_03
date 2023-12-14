using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class Home : Form
    {
        private Login parent;

        public Home(Login parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Home_Load(object sender, System.EventArgs e)
        {
            if (!AuthBUS.IsAuthenticate())
            {
                Close();
                return;
            }
            switch (AuthBUS.User.Loai)
            {
                case 0:
                case 1:
                case 2:
                    (txtMa.Text, txtHoTen.Text, txtQueQuan.Text, txtDiaChi.Text, txtGioiTinh.Text) =
                        (
                            AuthBUS.User.Ma,
                            AuthBUS.User.HoTen,
                            AuthBUS.User.QueQuan,
                            AuthBUS.User.DiaChi,
                            (bool)AuthBUS.User.GioiTinh ? "Nam" : "Nữ"
                        );
                    break;
                default:
                    Close();
                    return;
            }
            switch (AuthBUS.User.Loai)
            {
                case 0:
                    (lblUser.Text, lblMa.Text) = ("Thông tin quản trị viên", "MÃ ADMIN:");
                    qlmhMenuItem.Visible =
                        qllhpMenuItem.Visible =
                        qlsvMenuItem.Visible =
                        qlgvMenuItem.Visible =
                        qldMenuItem.Visible =
                            true;
                    break;
                case 1:
                    (lblUser.Text, lblMa.Text, txtKhoa.Text) = (
                        "Thông tin giảng viên",
                        "MSGV:",
                        AuthBUS.User.GiangViens.First().Khoa.Ten
                    );
                    pnlKhoa.Visible = dkhpMenuItem.Visible = tchpMenuItem.Visible = true;
                    break;
                case 2:
                    (lblUser.Text, lblMa.Text, txtKhoa.Text) = (
                        "Thông tin sinh viên",
                        "MSSV:",
                        AuthBUS.User.SinhViens.First().Khoa.Ten
                    );
                    pnlKhoa.Visible = dkldMenuItem.Visible = true;
                    break;
                default:
                    Close();
                    return;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool confirm =
                MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNoCancel)
                == DialogResult.Yes;
            if (!AuthBUS.Logout() || !confirm)
            {
                e.Cancel = true;
                return;
            }
            parent.Show();
        }

        private void logoutMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
