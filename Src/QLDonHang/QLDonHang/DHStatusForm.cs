using QLDonHang.Models;
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

namespace QLDonHang
{
    public partial class DHStatusForm : Form
    {
        DataRow usld;
        string oderId, conn, status;
        public bool isSave;
        public DHStatusForm(string oderId,
            DataRow usld, string conn, string status)
        {
            InitializeComponent();
            this.usld = usld;
            this.oderId = oderId;
            this.conn = conn;
            this.status = status;
            isSave = false;
        }

        private void DHStatusForm_Load(object sender, EventArgs e)
        {
            MyDao myDao = new MyDao(conn);
            var dt = myDao.GetLuongDuyet();
            cbStatus.Items.Clear();
            cbStatus.DataSource = dt;
            cbStatus.ValueMember = "TenLuongDuyet";
            cbStatus.DisplayMember = "TenLuongDuyet";
            cbStatus.SelectedValue = status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDao myDao = new MyDao(conn);
            var order = new Orders()
            {
                Id = oderId,
                OrderStatus = cbStatus.Text,
            };
            if(myDao.UpdateStatus(order))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
            this.Close();
            QLDonHangForm frm = new QLDonHangForm(conn);
            isSave = true;
        }
    }
}
