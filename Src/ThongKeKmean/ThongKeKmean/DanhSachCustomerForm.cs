using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongKeKmean
{
    public partial class DanhSachCustomerForm : Form
    {
        public DanhSachCustomerForm(DataTable data)
        {
            InitializeComponent();
            loadCustomer(data);
        }
        public void loadCustomer(DataTable customers)
        {
            if(customers == null)
            {
                MessageBox.Show("Data null");
                return;
            }
            dgrvCustomer.DataSource = customers;

            dgrvCustomer.Columns["UserId"].HeaderText = "Mã";
            dgrvCustomer.Columns["FullName"].HeaderText = "Họ Tên";
            dgrvCustomer.Columns["Email"].HeaderText = "Email";
            dgrvCustomer.Columns["Address"].HeaderText = "Địa chỉ";
            dgrvCustomer.Columns["Age"].HeaderText = "Tuổi";
            dgrvCustomer.Columns["TotalPurchaseAmount"].HeaderText = "Tổng tiền";
            dgrvCustomer.Columns["Cluster"].HeaderText = "Nhóm";
        }
    }
}
