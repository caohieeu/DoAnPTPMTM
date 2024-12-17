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
    public partial class QLDonHangForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;
        private DataTable childTable;
        public QLDonHangForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            dataGridViewOrder.DataSource = bsOrder;
            dataGridViewOrderDetail.DataSource = bsOrderDetail;
        }
        public void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);

            DataSet dts = myDao.GetDonHang();
            masterTable = dts.Tables[0];
            childTable = dts.Tables[1];

            DataColumn[] cols = new DataColumn[] { masterTable.Columns["Id"] };
            DataColumn[] cols2 = new DataColumn[] { childTable.Columns["OrderId"] };
            DataRelation dataRelation = new DataRelation("Odr", cols, cols2, false);

            dts.Relations.Add(dataRelation);

            bsOrder.DataSource = dts;
            bsOrder.DataMember = masterTable.TableName;

            bsOrderDetail.DataSource = bsOrder;
            bsOrderDetail.DataMember = "Odr";
            if (dataGridViewOrder.Columns.Count > 0)
            {
                dataGridViewOrder.Columns["Id"].HeaderText = "Mã Đơn Hàng";
                dataGridViewOrder.Columns["UserID"].HeaderText = "Mã Người Dùng";
                dataGridViewOrder.Columns["ShippingAddress"].HeaderText = "Địa Chỉ Giao Hàng";
                dataGridViewOrder.Columns["PaymentMethod"].HeaderText = "Phương Thức Thanh Toán";
                dataGridViewOrder.Columns["OrderStatus"].HeaderText = "Trạng Thái Đơn Hàng";
                dataGridViewOrder.Columns["DeliveryStatus"].HeaderText = "Trạng Thái Vận Chuyển";
                dataGridViewOrder.Columns["OrderDate"].HeaderText = "Ngày Đặt Hàng";
                dataGridViewOrder.Columns["TenLuongDuyet"].HeaderText = "Tên Luồng Duyệt";
            }

            if (dataGridViewOrderDetail.Columns.Count > 0)
            {
                dataGridViewOrderDetail.Columns["Id"].HeaderText = "Mã Chi Tiết Đơn Hàng";
                dataGridViewOrderDetail.Columns["OrderId"].HeaderText = "Mã Đơn Hàng";
                dataGridViewOrderDetail.Columns["ProductId"].HeaderText = "Mã Sản Phẩm";
                dataGridViewOrderDetail.Columns["Quantity"].HeaderText = "Số Lượng";
                dataGridViewOrderDetail.Columns["Price"].HeaderText = "Giá Sản Phẩm";
            }
        }
        private void QLDonHangForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void dataGridViewOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderId = ((DataRowView)bsOrder.Current)["Id"].ToString();
            string orderStatus = ((DataRowView)bsOrder.Current)["OrderStatus"].ToString();
            var dHStatusForm = new DHStatusForm(orderId, null, _connectionString, orderStatus);

            var rows = childTable.Select($"OrderId = '{orderId}'");

            List<OrderDetailDto> orderDetailList = new List<OrderDetailDto>();
            foreach (DataRow row in rows)
            {
                OrderDetailDto orderDetailDto = new OrderDetailDto
                {
                    ProductId = row["ProductId"].ToString(),
                    Quantity = Convert.ToInt32(row["Quantity"])
                };

                orderDetailList.Add(orderDetailDto);
            }


            dHStatusForm.orderDetails = orderDetailList;
            dHStatusForm.ShowDialog();
            if(dHStatusForm.isSave)
            {
                LoadData();
            }
        }
    }
}
