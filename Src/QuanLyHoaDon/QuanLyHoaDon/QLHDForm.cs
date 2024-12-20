﻿using QuanLyHoaDon.DAO;
using QuanLyHoaDon.Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
    public partial class QLHDForm : Form
    {
        private readonly string _connectionString;
        private List<Order> oders = new List<Order>();
        OrderDao orderDao;
        OrderDetailDao orderDetailDao;
        public QLHDForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }
        private void QLHDForm_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void LoadDataToGrid()
        {
            OrderDao orderDao = new OrderDao(_connectionString);
            var dataTable = orderDao.GetOrders();

            List<Order> orders = new List<Order>();

            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order
                {
                    Id = row["Id"].ToString(),
                    UserID = row["UserID"].ToString(),
                    ShippingAddress = row["ShippingAddress"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString(),
                    OrderStatus = row["OrderStatus"].ToString(),
                    DeliveryStatus = row["DeliveryStatus"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"])
                };
                orders.Add(order);
            }
            grdHoaDon.DataSource = new BindingList<Order>(orders);
            if (grdHoaDon.Columns.Count > 0)
            {
                grdHoaDon.Columns["Id"].HeaderText = "Mã Đơn Hàng";
                grdHoaDon.Columns["UserID"].HeaderText = "Mã Người Dùng";
                grdHoaDon.Columns["ShippingAddress"].HeaderText = "Địa Chỉ Giao Hàng";
                grdHoaDon.Columns["PaymentMethod"].HeaderText = "Phương Thức Thanh Toán";
                grdHoaDon.Columns["OrderStatus"].HeaderText = "Trạng Thái Đơn Hàng";
                grdHoaDon.Columns["DeliveryStatus"].HeaderText = "Trạng Thái Vận Chuyển";
                grdHoaDon.Columns["OrderDate"].HeaderText = "Ngày Đặt Hàng";
            }
        }
        private void ShowDetailForm(string type, string param)
        {
            orderDao = new OrderDao(_connectionString);
            orderDetailDao = new OrderDetailDao(_connectionString);

            ExecuteOrder execute = new ExecuteOrder(orderDao, orderDetailDao);
            XuatHDForm manageForm = new XuatHDForm(execute, this, param);
            manageForm.ShowDialog();
        }
        private void grdHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var oderId = grdHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            ShowDetailForm("infor", oderId);
        }

        private void QLHDForm_Resize(object sender, EventArgs e)
        {
            lblHeader.Left = (this.ClientSize.Width - lblHeader.Width) / 2;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTim.Text != null)
            {
                OrderDao orderDao = new OrderDao(_connectionString);
                var dataTable = orderDao.GetOrderById(txtTim.Text);

                List<Order> orders = new List<Order>();

                //foreach (DataRow row in dataTable.Rows)
                //{
                //    Order order = new Order
                //    {
                //        Id = row["Id"].ToString(),
                //        UserID = row["UserID"].ToString(),
                //        ShippingAddress = row["ShippingAddress"].ToString(),
                //        PaymentMethod = row["PaymentMethod"].ToString(),
                //        OrderStatus = row["OrderStatus"].ToString(),
                //        DeliveryStatus = row["DeliveryStatus"].ToString(),
                //        OrderDate = Convert.ToDateTime(row["OrderDate"])
                //    };
                //    orders.Add(order);
                //}
                //grdHoaDon.DataSource = new BindingList<Order>(orders);

                MessageBox.Show("Tạm thời chưa làm =))!");
            }
            else
            {
                MessageBox.Show("Hãy điền thông tin trước khi tìm kiếm!");
            }
        }
    }
}
