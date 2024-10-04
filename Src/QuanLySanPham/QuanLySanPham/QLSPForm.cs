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
        private List<Brand> brands = new List<Brand>();
        private List<Category> categories = new List<Category>();
        ProductDao productDao;
        public QLSPForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
            grdSP.UserAddedRow += grdSP_UserAddedRow;
            LoadCategories();
            LoadBrands();
        }

        private void LoadCategories()
        {
            productDao = new ProductDao(_connectionString);
            var dataTable = productDao.GetCategories();
            categories.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Category category = new Category(row["Id"].ToString(), row["Name"].ToString());
                categories.Add(category);
            }
            comboBoxCategoryID.DataSource = categories;
            comboBoxCategoryID.DisplayMember = "Name";
            comboBoxCategoryID.ValueMember = "Id";
        }


        private void LoadBrands()
        {
            productDao = new ProductDao(_connectionString);
            var dataTable = productDao.GetBrands();
            brands.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Brand brand = new Brand(row["Id"].ToString(), row["Name"].ToString());
                brands.Add(brand);
            }
            comboBoxBrandID.DataSource = brands;
            comboBoxBrandID.DisplayMember = "Name";
            comboBoxBrandID.ValueMember = "Id";
        }
        private void grdSP_UserAddedRow(object? sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow newRow = e.Row;
        }

        private void QLSPForm_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
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
                    BrandID = row["BrandID"].ToString()
                };
                products.Add(product);
            }

            grdSP.DataSource = new BindingList<Product>(products);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            productDao = new ProductDao(_connectionString);
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string productId = txtId.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    productDao.DeleteProduct(productId);

                    LoadDataToGrid();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            productDao = new ProductDao(_connectionString);

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string productId = txtId.Text;
                string name = txtName.Text;
                string description = txtDescription.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string imageUrl = txtUrl.Text;
                string categoryId = comboBoxCategoryID.SelectedValue.ToString();
                string brandId = comboBoxBrandID.SelectedValue.ToString();
                DateTime dateCreated = dateTimePickerNgayTao.Value;
                DateTime datePurchase = dateTimePickerNgayBan.Value;
                int stock = int.Parse(txtStock.Text);
                Product product = new Product(productId, name, description, price, imageUrl, categoryId, brandId, dateCreated, datePurchase, stock);
                productDao.UpdateProduct(product);
                LoadDataToGrid();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
            }
        }


        private void grdSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdSP.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtUrl.Text = row.Cells["ImageURL"].Value.ToString();
                comboBoxCategoryID.SelectedValue = row.Cells["CategoryID"].Value.ToString();
                comboBoxBrandID.SelectedValue = row.Cells["BrandID"].Value.ToString();
                dateTimePickerNgayTao.Value = DateTime.Parse(row.Cells["DateCreated"].Value.ToString());
                dateTimePickerNgayBan.Value = DateTime.Parse(row.Cells["DatePurchase"].Value.ToString());
                txtStock.Text = row.Cells["Stock"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                productDao = new ProductDao(_connectionString);
                string id = txtId.Text;
                string name = txtName.Text;
                string description = txtDescription.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string imageUrl = txtUrl.Text;
                string categoryId = comboBoxCategoryID.SelectedValue.ToString();
                string brandId = comboBoxBrandID.SelectedValue.ToString();
                DateTime dateCreated = dateTimePickerNgayTao.Value;
                DateTime datePurchase = dateTimePickerNgayBan.Value;
                int stock = int.Parse(txtStock.Text);
                Product product = new Product(id, name, description, price, imageUrl, categoryId, brandId, dateCreated, datePurchase, stock);
                productDao.InsertProduct(product);
                LoadDataToGrid();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Hãy thêm dữ liệu vào textbox!");
            }
        }
    }
}
