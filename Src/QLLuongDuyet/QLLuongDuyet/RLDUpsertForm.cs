using QLLuongDuyet.DAO;
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
    public partial class RLDUpsertForm : Form
    {
        public bool IsSave { set; get; }
        string conn, luongDuyetId, id;
        DataRowView rld;
        int mode;
        public RLDUpsertForm(
            string conn,
            int mode,
            string luongDuyetId,
            DataRowView rld
            )
        {
            InitializeComponent();
            this.conn = conn;
            this.mode = mode;
            this.luongDuyetId = luongDuyetId;
            this.rld = rld;
            IsSave = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtRole.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var usldSave = new Models.RoleLuongDuyet
            {
                Id = id,
                RoleId = txtRole.SelectedValue.ToString(),
                LuongDuyetId = luongDuyetId,
            };
            MyDao myDao = new MyDao(conn);
            if (mode == 0)
            {
                myDao.AddRLD(usldSave);
            }
            else if (mode == 1)
            {
                myDao.UpdateRLD(usldSave);
            }
            IsSave = true;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RLDUpsertForm_Load(object sender, EventArgs e)
        {
            MyDao mydao = new MyDao(conn);
            var dt = mydao.GetRole();
            txtRole.DataSource = dt;
            txtRole.ValueMember = "Id";
            txtRole.DisplayMember = "Name";

            if (rld != null)
            {
                txtRole.SelectedValue = rld["RoleId"].ToString();
                id = rld["Id"].ToString();
            }
            else
            {
                id = Guid.NewGuid().ToString().Substring(0, 25);
            }
        }
    }
}
