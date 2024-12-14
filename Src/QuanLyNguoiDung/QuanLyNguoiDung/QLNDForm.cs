using QuanLyNguoiDung.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class QLNDForm : Form
    {
        private readonly string _connectionString;
        public QLNDForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();

            grdUser.CellDoubleClick += GrdUser_CellDoubleClick;
        }
        private void ShowDetailForm(string type, string param)
        {
            MyDao myDao = new MyDao(_connectionString);
            Execute execute = new Execute(myDao);
            AddForm addForm = new AddForm(execute, this, type, param);


            addForm.ShowDialog();
        }
        private void GrdUser_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            var userId = grdUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            ShowDetailForm("modified", userId);
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {

            ShowDetailForm("add", string.Empty);
        }

        public void QLNDForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                this.WindowState = FormWindowState.Maximized;
                MyDao myDao = new MyDao(_connectionString);
                DataTable dt = myDao.GetData();
                grdUser.DataSource = dt;

                if (grdUser.Columns.Count > 0)
                {
                    grdUser.Columns["Id"].HeaderText = "Mã Người Dùng";
                    grdUser.Columns["FullName"].HeaderText = "Họ và Tên";
                    grdUser.Columns["UserName"].HeaderText = "Tên Đăng Nhập";
                    grdUser.Columns["PasswordHash"].HeaderText = "Mật Khẩu";
                    grdUser.Columns["Email"].HeaderText = "Email";
                    grdUser.Columns["Phone"].HeaderText = "Số Điện Thoại";
                    grdUser.Columns["Birth"].HeaderText = "Ngày Sinh";
                    grdUser.Columns["ImagePath"].HeaderText = "Đường Dẫn Ảnh";
                    grdUser.Columns["Address"].HeaderText = "Địa Chỉ";
                    grdUser.Columns["RoleId"].HeaderText = "Mã Vai Trò";
                }
            }
        }
    }
}
