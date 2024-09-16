
using System;
using System.Windows.Forms;

namespace LoginLibrary
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
            this.cbShow.Click += cbShow_click;
            this.btnLogin.Click += btnLogin_click;
        }

        private void btnLogin_click(object sender, System.EventArgs e)
        {
            String tk = txtUserName.Text;
            String mk = txtPassWord.Text;
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Tai khoan hoac mat khau trong! Hay dien day du");
            }
            else if (mk == "luan" && tk == "luan")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void cbShow_click(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassWord.PasswordChar = '\0';
            }
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }
    }
}
