using QuanLyNCC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNCC
{
    public partial class QLNCCUpsertForm : Form
    {
        public bool IsSave { set; get; }
        string conn;
        int mode;
        DataRowView provider;

        public QLNCCUpsertForm()
        {
            InitializeComponent();
        }
        public QLNCCUpsertForm(
            string Conn
            , int mode
        )
        {
            InitializeComponent();
            this.conn = Conn;
            this.mode = mode;
            IsSave = false;
        }
        public QLNCCUpsertForm(
            string Conn
            , int mode
            , DataRowView provider
        )
        {
            InitializeComponent();
            this.conn = Conn;
            this.mode = mode;
            this.provider = provider;
            IsSave = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty
                || txtName.Text == string.Empty
                || txtAddress.Text == string.Empty
                || txtPhone.Text == string.Empty
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var provider = new Models.Provider
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
            };
            MyDao myDao = new MyDao(conn);
            if (mode == 0)
            {
                myDao.AddProvider(provider);
            }
            else if (mode == 1)
            {
                myDao.UpdateProvider(provider);
            }
            IsSave = true;
            Close();
        }

        private void UpsertForm_Load(object sender, EventArgs e)
        {
            if (provider != null)
            {
                txtId.Text = provider["id"].ToString();
                txtName.Text = provider["name"].ToString();
                txtAddress.Text = provider["address"].ToString();
                txtPhone.Text = provider["phone"].ToString();

                txtId.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
