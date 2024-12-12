using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BCrypt.Net;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public bool IsSuccess = false;
        MyDbContext myDbContext;
        public string _Conn;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public LoginForm(string _Conn)
        {
            this._Conn = _Conn;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tên tài khoản!");
                this.txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassWord.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!");
                this.txtPassWord.Focus();
                return;
            }
  
            var result = Check_User(txtUserName.Text, txtPassWord.Text);
            if (result == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return;
            }

            IsSuccess = true;

            Enviroment.UserID = result["id"].ToString();
            Enviroment.UserName = result["username"].ToString();
            Enviroment.UserRole = result["roleid"].ToString();

            Close();
        }
        public DataRow Check_User(string pUser, string pPass)
        {
   
            myDbContext = new MyDbContext(_Conn);
            string sqlCommand = "SELECT * FROM Users WHERE Username = @username";
            CommandType commandType = CommandType.Text;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", pUser)
            };
            DataTable dt = myDbContext.ExecuteQuery(sqlCommand, commandType, parameters);

            string pass = dt?.Rows[0]?["passwordhash"]?.ToString() ?? string.Empty;
            if (pass == string.Empty && pass != pPass && !BCrypt.Net.BCrypt.Verify(pPass, pass))
                return null;

            if (dt == null || dt.Rows.Count == 0)
                return null;
            return dt.Rows[0];
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
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
