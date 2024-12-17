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
        DataTable dttable;
        DataRow usld;
        string oderId, conn, status;
        public bool isSave;
        public List<OrderDetailDto> orderDetails;
        public DHStatusForm(string oderId,
            DataRow usld, string conn, string status)
        {
            InitializeComponent();
            this.usld = usld;
            this.oderId = oderId;
            this.conn = conn;
            this.status = status;
            isSave = false;

            dataGridView1.DataSource = bindingSource1;
        }

        private void DHStatusForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {

            MyDao myDao = new MyDao(conn);

            var dt = myDao.GetLuongDuyet(oderId);

            cbStatus.DataSource = dt.Tables[0];
            cbStatus.ValueMember = "TenLuongDuyet";
            cbStatus.DisplayMember = "TenLuongDuyet";
            cbStatus.SelectedValue = status;

            dttable = dt.Tables[1];
            bindingSource1.DataSource = dttable;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["edate"].HeaderText = "Ngày Duyệt";
                dataGridView1.Columns["orderid"].HeaderText = "Mã Hóa Đơn";
                dataGridView1.Columns["UserName"].HeaderText = "Tài Khoản";
                dataGridView1.Columns["TenLuongDuyet"].HeaderText = "Tên Luồng Duyệt";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDao myDao = new MyDao(conn);
            var order = new Orders()
            {
                Id = oderId,
                OrderStatus = cbStatus.Text,
            };
            if (myDao.UpdateStatus(order))
            {
                if(status == "Prepare")
                {
                    foreach(var orderItem in orderDetails)
                    {
                        var newStock = myDao.GetStockProduct(orderItem.ProductId) - orderItem.Quantity;
                        myDao.UpdateStockProduct(orderItem.ProductId, newStock);
                    }
                }
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
            isSave = true;
            status = cbStatus.SelectedValue.ToString();
            RefreshData();
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {


        }
    }
}
