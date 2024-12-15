using Microsoft.VisualBasic.ApplicationServices;
using QuanLySanPham.DAO;
using QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private List<Brand> brands = new List<Brand>();
        private List<Category> categories = new List<Category>();
        private List<Provider> providers = new List<Provider>();
        public ManageForm(Execute execute, QLSPForm qLSPForm, string typeForm, string param)
        {
            InitializeComponent();
            btnSua.Visible = false;
            _execute = execute;
            _qLSPForm = qLSPForm;
            _typeForm = typeForm;
            this.param = param;
            LoadCategories();
            LoadBrands();
            LoadForm();
            LoadProduct();
            LoadProvider();

            ImageLocation = txtUrl.Text;
        }
        public void LoadForm()
        {
            if (_typeForm == "modified")
            {
                btnSua.Visible = true;
                button1.Visible = true;
                btnThem.Visible = false;
                txtId.Enabled = false;
            }
            else
            {
                btnSua.Visible = false;
                btnThem.Visible = true;
                button1.Visible =  false;
            }

        }
        private async void LoadProduct()
        {
            if (param != string.Empty)
            {
                var product = _execute.getPrById(param);

                if (product != null)
                {
                    string appBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    DirectoryInfo parentDirectory = Directory.GetParent(appBaseDirectory)?.Parent?.Parent?.Parent?.Parent;
                    string imagesPath = Path.Combine(parentDirectory.FullName, "ShoeShop") + product.ImageURL;

                    txtId.Text = product.Id;
                    txtName.Text = product.Name;
                    txtDescription.Text = product.Description;
                    txtPrice.Text = product.Price.ToString();
                    txtUrl.Text = product.ImageURL;
                    comboBoxCategoryID.SelectedValue = product.CategoryID;
                    comboBoxBrandID.SelectedValue = product.BrandID;
                    txtStock.Text = product.Stock.ToString();

                    try
                    {
                        using (var fileStream = new FileStream(imagesPath, FileMode.Open, FileAccess.Read))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                fileStream.CopyTo(memoryStream);
                                memoryStream.Position = 0; // Reset position before reading
                                ptrBoxProduct.Image = Image.FromStream(memoryStream);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ptrBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
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
        private void LoadProvider()
        {
            var dataTable = _execute.getProvider();
            providers.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Provider provider = new Provider(row["Id"].ToString(), row["Name"].ToString(), row["Address"].ToString(), row["Phone"].ToString());
                providers.Add(provider);
            }
            cbbProviderId.DataSource = providers;
            cbbProviderId.DisplayMember = "Name";
            cbbProviderId.ValueMember = "Id";
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
                    int stock = (int)txtStock.Value;
                    string providerId = cbbProviderId.SelectedValue.ToString();
                    currentProduct = new Product(id, name, description, price, imageUrl, categoryId, brandId, DateTime.UtcNow, DateTime.UtcNow, stock, providerId);
                    if (_execute.Add(currentProduct))
                    {
                        File.Copy(ptrBoxProduct.ImageLocation, txtUrl.Tag.ToString(), overwrite: true);

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
                    int stock = (int)txtStock.Value;
                    string providerId = cbbProviderId.SelectedValue.ToString();
                    currentProduct = new Product(productId, name, description, price, imageUrl, categoryId, brandId, DateTime.UtcNow, DateTime.UtcNow, stock, providerId);
                    if (_execute.UpdateProduct(currentProduct))
                    {
                        File.Copy(ptrBoxProduct.ImageLocation, txtUrl.Tag.ToString(), overwrite: true);

                        MessageBox.Show("Sửa sản phẩm thành công!");
                        this.Close();
                        _qLSPForm.QLSPForm_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex);
            }
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtId.Text))
        //    {
        //        string productId = txtId.Text;

        //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            if (_execute.DeleteProduct(param))
        //            {
        //                MessageBox.Show("Xóa thành công");
        //                this.Close();
        //                _qLSPForm.QLSPForm_Load(sender, e);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi xóa");
        //                this.Close();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
        //    }
        //}

        private void btnUpload_Click(object sender, EventArgs e)
        {

            try
            {
                string appBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo parentDirectory = Directory.GetParent(appBaseDirectory)?.Parent?.Parent?.Parent?.Parent;
                string imagesPath = Path.Combine(parentDirectory.FullName, "ShoeShop", "images");

                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*"
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string guid = Guid.NewGuid().ToString().Substring(0, 10);
                    string selectedFilePath = fileDialog.FileName;
                    string fileName = guid + fileDialog.SafeFileName;
                    string destinationPath = Path.Combine(imagesPath, fileName);

                    txtUrl.Text = "/images/" + fileName;
                    txtUrl.Tag = destinationPath;
                    ptrBoxProduct.Image = Image.FromFile(selectedFilePath);
                    ptrBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    ptrBoxProduct.ImageLocation = selectedFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuatHangForm xhForm = new XuatHangForm(_execute, param);
            xhForm.ShowDialog();
        }
    }
}
