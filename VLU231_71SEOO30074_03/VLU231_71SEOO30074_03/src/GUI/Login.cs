using System.Runtime.CompilerServices;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            ptbLoader.Visible = true;
            bool isAuthorized = AuthBUS.Login(txtUsername.Text, txtPassword.Text);
            if (!isAuthorized)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
            else
            {
                Hide();
                Home homeForm = new Home();
                homeForm.FormClosing += HomeForm_FormClosing;
                homeForm.Show();
            }
            ptbLoader.Visible = false;
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool confirm =
                MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNoCancel)
                == DialogResult.Yes;
            if (!AuthBUS.Logout() || !confirm)
            {
                e.Cancel = true;
                return;
            }
            Show();
        }
    }
}
