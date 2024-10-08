﻿using Microsoft.VisualBasic.ApplicationServices;
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

namespace QuanLySanPham
{
    public partial class ManageForm : Form
    {
        private string ImageLocation = "";
        private readonly Execute _execute;
        private readonly QLSPForm _qLSPForm;
        private string _typeForm = "";
        public string param = string.Empty;
        public Product currentProduct;
        private List<Product> products = new List<Product>();
        private List<Brand> brands = new List<Brand>();
        private List<Category> categories = new List<Category>();
        public ManageForm(Execute execute, QLSPForm qLSPForm, string typeForm, string param)
        {
            InitializeComponent();
            btnSua.Visible = false;
            btnXoa.Visible = false;
            _execute = execute;
            _qLSPForm = qLSPForm;
            _typeForm = typeForm;
            this.param = param;
            LoadCategories();
            LoadBrands();
            LoadForm();
            LoadProduct();
        }
        public void LoadForm()
        {
            if (_typeForm == "modified")
            {
                btnSua.Visible = true;
                btnThem.Visible = false;
                btnXoa.Visible = true;
            }
            else
            {
                btnSua.Visible = false;
                btnThem.Visible = true;
                btnXoa.Visible = false;
            }

        }
        private void LoadProduct()
        {
            if (param != string.Empty)
            {
                var product = _execute.getPrById(param);

                if (product != null)
                {
                    txtId.Text = product.Id;
                    txtName.Text = product.Name;
                    txtDescription.Text = product.Description;
                    txtPrice.Text = product.Price.ToString();
                    txtUrl.Text = product.ImageURL;
                    comboBoxCategoryID.SelectedValue = product.CategoryID;
                    comboBoxBrandID.SelectedValue = product.BrandID;
                    dateTimePickerNgayTao.Value = product.DateCreated ?? DateTime.Now;
                    dateTimePickerNgayBan.Value = product.DatePurchase ?? DateTime.Now;
                    txtStock.Text = product.Stock.ToString();
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
                }
            }
        }
        private void LoadCategories()
        {
            var dataTable = _execute.getCategories();
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
            var dataTable = _execute.getBrand();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
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
                    currentProduct = new Product(id, name, description, price, imageUrl, categoryId, brandId, dateCreated, datePurchase, stock);
                    if (_execute.Add(currentProduct))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        this.Close();
                        _qLSPForm.QLSPForm_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy thêm dữ liệu vào textbox!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
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
                    currentProduct = new Product(productId, name, description, price, imageUrl, categoryId, brandId, dateCreated, datePurchase, stock);
                    if (_execute.UpdateProduct(currentProduct))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!");
                        this.Close();
                        _qLSPForm.QLSPForm_Load(sender, e);
                    }
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string productId = txtId.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_execute.DeleteProduct(param))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.Close();
                        _qLSPForm.QLSPForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = fileDialog.FileName;
                    string imageName = fileDialog.SafeFileName;

                    txtUrl.Text = Guid.NewGuid() + imageName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error have occured", "400", MessageBoxButtons.OK);
            }
        }
    }
}
