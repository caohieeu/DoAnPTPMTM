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
    public partial class QLNCCForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;

        public QLNCCForm(string connectionString)
        {
            InitializeComponent();

            _connectionString = connectionString;
            grdNCC.DataSource = bsGrid;
        }
        private void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);

            DataSet dts = myDao.GetProvider();
            masterTable = dts.Tables[0];

            bsGrid.DataSource = masterTable;

            if (grdNCC.Columns.Count > 0)
            {
                grdNCC.Columns["Id"].HeaderText = "Mã Nhà Cung Cấp";
                grdNCC.Columns["Name"].HeaderText = "Tên Nhà Cung Cấp";
                grdNCC.Columns["Address"].HeaderText = "Địa Chỉ";
                grdNCC.Columns["Phone"].HeaderText = "Số Điện Thoại";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new QLNCCUpsertForm(_connectionString, 0);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null) return;

            var frm = new QLNCCUpsertForm(_connectionString, 1, (DataRowView)bsGrid.Current);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null) return;
            MessageBox.Show("pending");
        }
        private void QLNCCForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            LoadData();
        }
    }
}
