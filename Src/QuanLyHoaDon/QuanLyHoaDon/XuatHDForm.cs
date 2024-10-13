using QuanLyHoaDon.DAO;
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
    public partial class XuatHDForm : Form
    {
        private string ImageLocation = "";
        private readonly ExecuteOrder _execute;
        private readonly QLHDForm _qLHDForm;
        private string _typeForm = "";
        public string param = string.Empty;
        public Order currentOrder;
        public XuatHDForm(ExecuteOrder execute, QLHDForm qLHDForm, string param)
        {
            InitializeComponent();
            _execute = execute;
            _qLHDForm = qLHDForm;
            this.param = param;
        }

        private void LoadDataToGrid()
        {
            var dataTable = _execute.GetOrderDetails(param);
            List<OrderDetail> lst = new List<OrderDetail>();
            foreach (DataRow row in dataTable.Rows)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    Id = row["Id"].ToString(),
                    OrderId = row["OrderId"].ToString(),
                    ProductId = row["ProductId"].ToString(),
                    Quantity = int.Parse(row["Quantity"].ToString()),
                    Price = decimal.Parse(row["Price"].ToString())
                };
                lst.Add(orderDetail);
            }
            grdDetailOrder.DataSource = new BindingList<OrderDetail>(lst);
        }
        private void LoadDataToText()
        {
            Order order = _execute.GetOrderById(param);
            lblIdOder.Text = order.Id;
            lblAdd.Text = order.ShippingAddress;
            lblCus.Text = order.UserID;
            lblDeliver.Text = order.DeliveryStatus;
            lblOderAt.Text = order.OrderDate.ToString();
            lblOderStatus.Text = order.OrderStatus;
            lblPayMethod.Text = order.PaymentMethod;
            txtThanhTien.Text = _execute.GetTotalPriceByOrderId(param).ToString() + " USD";
        }
        private void XuatHDForm_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadDataToText();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Invoice";
                saveFileDialog.FileName = "HoaDon_" + param;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PDFGenerator pDFGenerator = new PDFGenerator();
                    string filePath = saveFileDialog.FileName;  

                    pDFGenerator.GenerateInvoicePDF(filePath, lblIdOder.Text, lblCus.Text, lblAdd.Text, lblOderAt.Text, lblOderStatus.Text, lblPayMethod.Text, lblDeliver.Text, grdDetailOrder, txtThanhTien.Text);

                    MessageBox.Show("Xuất hóa đơn thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xuất được hóa đơn: " + ex.Message);
            }
        }

    }
}
