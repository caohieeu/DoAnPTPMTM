using QuanLyRoleMenu.DAO;
using QuanLyRoleMenu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRoleMenu
{
    public partial class ManagerRole : Form
    {
        public bool IsSave { set; get; }
        public string conn;
        public int mode;
        Role role;
        public ManagerRole(string conn, int mode, Role role)
        {
            InitializeComponent();
            this.conn = conn;
            this.mode = mode;
            this.role = role;
            IsSave = false;
            if (mode == 1)
            {
                lblTitle.Text = "Sửa Role";
                txtMa.Enabled = false;
                txtMa.Text = role.Id;
            }
            else
            {
                lblTitle.Text = "Thêm Role";
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == string.Empty || txtMa.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RoleDao roleDao = new RoleDao(conn);
            role = new Role(txtMa.Text, txtTen.Text);
            if (mode == 0)
            {
                roleDao.InsertRole(role);
            }
            else if (mode == 1)
            {
                roleDao.UpdateRole(role);
            }
            IsSave = true;
            Close();
        }
    }
}
