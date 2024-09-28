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
        public QLSPForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();

            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            grdSP.UserAddedRow += grdSP_UserAddedRow;
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


        private void btnXoa_Click(object? sender, EventArgs e)
        {
            int CurrentIndex = grdSP.CurrentCell.RowIndex;
            if (CurrentIndex > 0)
            {
                var selectedRow = grdSP.Rows[CurrentIndex];
                string productId = selectedRow.Cells["Id"].Value.ToString();

                ProductDao productDao = new ProductDao(_connectionString);
                bool result = productDao.DeleteProduct(productId);

                if (result)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int CurrentIndex = grdSP.CurrentCell.RowIndex;
            if (CurrentIndex >= 0)
            {
                var selectedRow = grdSP.Rows[CurrentIndex];
                var productToUpdate = products[CurrentIndex]; 

                productToUpdate.Name = selectedRow.Cells["Name"].Value.ToString();
                productToUpdate.Description = selectedRow.Cells["Description"].Value.ToString();
                productToUpdate.Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                productToUpdate.ImageURL = selectedRow.Cells["ImageURL"].Value.ToString();
                productToUpdate.CategoryID = selectedRow.Cells["CategoryID"].Value.ToString();
                productToUpdate.BrandID = selectedRow.Cells["BrandID"].Value.ToString();
                productToUpdate.DateCreated = Convert.ToDateTime(selectedRow.Cells["DateCreated"].Value);
                productToUpdate.DatePurchase = Convert.ToDateTime(selectedRow.Cells["DatePurchase"].Value);
                productToUpdate.Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);

                ProductDao dao = new ProductDao(_connectionString);
                bool result = dao.UpdateProduct(productToUpdate);

                if (result)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng để sửa!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grdSP.EndEdit();
            DataGridViewRow newRow = grdSP.Rows[grdSP.Rows.Count - 2];
            if (newRow.Cells["Id"].Value != null &&
                newRow.Cells["Name"].Value != null &&
                newRow.Cells["Price"].Value != null &&
                newRow.Cells["Stock"].Value != null)
            {
                Product productToInsert = new Product
                {
                    Id = newRow.Cells["Id"].Value.ToString(),
                    Name = newRow.Cells["Name"].Value.ToString(),
                    Description = newRow.Cells["Description"].Value?.ToString(),
                    Price = Convert.ToDecimal(newRow.Cells["Price"].Value),
                    ImageURL = newRow.Cells["ImageURL"].Value?.ToString(),
                    CategoryID = newRow.Cells["CategoryID"].Value?.ToString(),
                    BrandID = newRow.Cells["BrandID"].Value?.ToString(),
                    DateCreated = Convert.ToDateTime(newRow.Cells["DateCreated"].Value),
                    DatePurchase = Convert.ToDateTime(newRow.Cells["DatePurchase"].Value),
                    Stock = Convert.ToInt32(newRow.Cells["Stock"].Value)
                };

                ProductDao dao = new ProductDao(_connectionString);
                bool result = dao.InsertProduct(productToInsert);

                if (result)
                {
                    MessageBox.Show("Lưu sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu sản phẩm thất bại!");
                }
            }
        }
    }
}
