using System.Runtime.CompilerServices;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.BUS;

namespace VLU231_71SEOO30074_03.src.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            ptbLoader.Visible = true;
            bool isAuthorized = await AuthBUS.Login(txtUsername.Text, txtPassword.Text);
            if (!isAuthorized)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
            else
            {
                Hide();
                (new Home(this)).Show();
            }
            ptbLoader.Visible = false;
        }
    }
}
