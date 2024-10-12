using QLLuongDuyet.DAO;
using QLLuongDuyet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongDuyet
{
    public partial class USDLUpsertForm : Form
    {
        public bool IsSave { set; get; }
        string conn, luongDuyetId, id;
        DataRow usld;
        int mode;
        public USDLUpsertForm(
            string conn,
            int mode,
            string luongDuyetId,
            DataRow usld
            )
        {
            InitializeComponent();
            this.conn = conn;
            this.mode = mode;
            this.luongDuyetId = luongDuyetId;
            this.usld = usld;
            IsSave = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var usldSave = new Models.UserLuongDuyet
            {
                Id = id,
                UserId = txtUser.SelectedValue.ToString(),
                LuongDuyetId = luongDuyetId,
                OrderId = usld?["OrderId"].ToString() ?? null
            };
            MyDao myDao = new MyDao(conn);
            if (mode == 0)
            {
                myDao.AddUSLD(usldSave);
            }
            else if (mode == 1)
            {
                myDao.UpdateUSLD(usldSave);
            }
            IsSave = true;
            Close();
        }

        private void USDLUpsertForm_Load(object sender, EventArgs e)
        {
            MyDao mydao = new MyDao(conn);
            var dt = mydao.GetUsers();
            txtUser.DataSource = dt;
            txtUser.ValueMember = "Id";
            txtUser.DisplayMember = "UserName";

            if (usld != null)
            {
                txtUser.SelectedValue = usld["UserId"].ToString();
                id = usld["Id"].ToString();
            }
            else
            {
                id = Guid.NewGuid().ToString().Substring(0, 25);
            }
        }
    }
}
