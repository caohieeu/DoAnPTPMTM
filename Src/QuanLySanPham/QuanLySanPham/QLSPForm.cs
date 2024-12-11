using QuanLySanPham.DAO;
using QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLySanPham
{
    public partial class QLSPForm : Form
    {
        private readonly string _connectionString;
        private List<Product> products = new List<Product>();
        ProductDao productDao;
        public QLSPForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }
        public void QLSPForm_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void ShowDetailForm(string type, string param)
        {
            productDao = new ProductDao(_connectionString);
            Execute execute = new Execute(productDao);
            ManageForm manageForm = new ManageForm(execute, this, type, param);
            manageForm.ShowDialog();
        }
        private void LoadDataToGrid()
        {
            ProductDao productDao = new ProductDao(_connectionString);
            var dataTable = productDao.GetData();

            products.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product
                {
                    Id = row["Id"].ToString(),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    ImageURL = row["ImageURL"].ToString(),
                    CategoryID = row["CategoryID"].ToString(),
                    DateCreated = Convert.ToDateTime(row["DateCreated"]),
                    DatePurchase = Convert.ToDateTime(row["DatePurchase"]),
                    Stock = Convert.ToInt32(row["Stock"]),
                    BrandID = row["BrandID"].ToString(),
                    ProviderId = row["ProviderId"].ToString()
                };
                products.Add(product);
            }

            grdSP.DataSource = new BindingList<Product>(products);
            grdSP.Columns["Id"].HeaderText = "Mã sản phẩm";
            grdSP.Columns["Name"].HeaderText = "Tên sản phẩm";
            grdSP.Columns["Description"].HeaderText = "Mô tả";
            grdSP.Columns["Price"].HeaderText = "Giá";
            grdSP.Columns["ImageURL"].HeaderText = "URL Hình ảnh";
            grdSP.Columns["CategoryID"].HeaderText = "Mã danh mục";
            grdSP.Columns["DateCreated"].HeaderText = "Ngày tạo";
            grdSP.Columns["DatePurchase"].HeaderText = "Ngày mua";
            grdSP.Columns["Stock"].HeaderText = "Số lượng";
            grdSP.Columns["BrandID"].HeaderText = "Mã thương hiệu";
            grdSP.Columns["ProviderId"].HeaderText = "Mã nhà cung cấp";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProductDao productDao = new ProductDao(_connectionString);
            if (txtSearch.Text != "")
            {
                var dataTable = productDao.GetProductByName(txtSearch.Text);

                products.Clear();
                grdSP.DataSource = null;
                foreach (DataRow row in dataTable.Rows)
                {
                    Product product = new Product
                    {
                        Id = row["Id"].ToString(),
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString(),
                        Price = Convert.ToDecimal(row["Price"]),
                        ImageURL = row["ImageURL"].ToString(),
                        CategoryID = row["CategoryID"].ToString(),
                        DateCreated = Convert.ToDateTime(row["DateCreated"]),
                        DatePurchase = Convert.ToDateTime(row["DatePurchase"]),
                        Stock = Convert.ToInt32(row["Stock"]),
                        BrandID = row["BrandID"].ToString(),
                        ProviderId = row["ProviderId"].ToString()
                    };
                    products.Add(product);
                }

                grdSP.DataSource = new BindingList<Product>(products);
            }
            else
            {
                MessageBox.Show("Hãy điền trước khi tìm kiếm!");
            }
        }

        private void grdSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = grdSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            ShowDetailForm("modified", product);
        }

        private void QLSPForm_Resize(object sender, EventArgs e)
        {
            lblHeaderl.Left = (this.ClientSize.Width - lblHeaderl.Width) / 2;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ShowDetailForm("add", string.Empty);
        }
    }
}
