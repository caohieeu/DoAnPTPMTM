using ProjectPTUDTM;
using QuanLyNguoiDung.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class AddForm : Form
    {
        private string ImageLocation = "";
        private readonly Execute _execute;
        private readonly QLNDForm _qLNDForm;
        private string _typeForm = "";
        public string param = string.Empty;
        public Users currentUser;
        public AddForm(Execute execute, QLNDForm qLNDForm, string typeForm, string param)
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            _execute = execute;
            _qLNDForm = qLNDForm;
            _typeForm = typeForm;
            this.param = param;
            LoadForm();
            LoadUser();
        }
        public void LoadForm()
        {
            if (_typeForm == "modified")
            {
                btnUpdate.Visible = true;
                btnAddNew.Visible = false;
                btnDelete.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
                btnAddNew.Visible = true;
                btnDelete.Visible = false;
            }

            cbRole.Items.Clear();

            var roles = _execute.GetRoles();

            cbRole.DataSource = roles;
            cbRole.DisplayMember = "Name";
            cbRole.ValueMember = "Id";
        }
        void LoadUser()
        {
            if (param != string.Empty)
            {
                var user = _execute.FindUserById(param);

                if (user != null)
                {
                    txtUserName.Text = user.UserName;
                    txtPassword.Text = user.Password;
                    cbRole.Text = user.RoleId;
                    txtEmail.Text = user.Email;
                    txtFullName.Text = user.FullName;
                    txtAddress.Text = user.Address;
                    dtpBirthday.Value = user.Birth ?? DateTime.Now;
                    txtPhone.Text = user.Phone;
                    txtImage.Text = user.ImagePath;
                }
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser = new Users()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    RoleId = cbRole.SelectedValue.ToString(),
                    Email = txtEmail.Text,
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    Birth = DateTime.ParseExact(dtpBirthday.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    ImagePath = txtImage.Text,
                    Phone = txtPhone.Text,
                };
                var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");
                File.Copy(ImageLocation, Path.Combine(resourePath, txtImage.Text), true);
                if (_execute.Add(currentUser))
                {
                    MessageBox.Show("Add new user successfully");
                    this.Close();
                    _qLNDForm.QLNDForm_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Error when add new user");
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
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

                    txtImage.Text = Guid.NewGuid() + imageName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error have occured", "400", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                Id = param,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                RoleId = cbRole.SelectedValue.ToString(),
                Email = txtEmail.Text,
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                Birth = DateTime.ParseExact(dtpBirthday.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImagePath = txtImage.Text,
                Phone = txtPhone.Text,
            };
            if (_execute.UpdateUser(user))
            {
                MessageBox.Show("Update successfully");
                this.Close();
                _qLNDForm.QLNDForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Update Error");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_execute.DeleteUser(param))
            {
                MessageBox.Show("Delete successfully");
                this.Close();
                _qLNDForm.QLNDForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Delete Error");
                this.Close();
            }
        }
    }
}
