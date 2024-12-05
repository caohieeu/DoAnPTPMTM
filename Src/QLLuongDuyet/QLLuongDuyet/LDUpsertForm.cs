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
    public partial class LDUpsertForm : Form
    {
        public bool IsSave { set; get; }
        string id;
        string conn;
        int mode;
        DataRowView luongDuyet;
        public LDUpsertForm(
            string Conn
            , int mode
        )
        {
            InitializeComponent();
            this.conn = Conn;
            this.mode = mode;
            IsSave = false;
        }
        public LDUpsertForm(
            string Conn
            , int mode
            , DataRowView luongDuyet
        )
        {
            InitializeComponent();
            this.conn = Conn;
            this.mode = mode;
            this.luongDuyet = luongDuyet;
            IsSave = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLuongDuyet.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var luongDuyet = new Models.LuongDuyet
            {
                Id = id,
                TenLuongDuyet = txtTenLuongDuyet.Text,
                ThuTu = (int)txtThuTu.Value
            };
            MyDao myDao = new MyDao(conn);
            if (mode == 0)
            {
                myDao.AddLuongDuyet(luongDuyet);
            }
            else if (mode == 1)
            {
                myDao.UpdateLuongDuyet(luongDuyet);
            }
            IsSave = true;
            Close();
        }

        private void UpsertForm_Load(object sender, EventArgs e)
        {
            if (luongDuyet != null)
            {
                txtTenLuongDuyet.Text = luongDuyet["TenLuongDuyet"].ToString();
                txtThuTu.Value = (int)luongDuyet["ThuTu"];
                id = luongDuyet["Id"].ToString();
            }
            else
            {
                id = Guid.NewGuid().ToString().Substring(0, 25);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
