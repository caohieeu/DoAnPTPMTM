using QLLuongDuyet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongDuyet
{
    public partial class QLLDForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;
        public QLLDForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            dataGridView1.DataSource = bsLD;
        }
        private void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);
            masterTable = myDao.GetLuongDuyet();
            bsLD.DataSource = masterTable;
        }
        private void QLLDForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void btnThemLD_Click(object sender, EventArgs e)
        {
            var frm = new UpsertForm(_connectionString, 0);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void btnSuaLD_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;

            var frm = new UpsertForm(_connectionString, 1, masterTable.Rows[bsLD.Position]);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void btnXoaLD_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;
            if (MessageBox.Show("Xác nhận xóa", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyDao myDao = new MyDao(_connectionString);
                myDao.DeleteLuongDuyet(masterTable.Rows[bsLD.Position]["Id"].ToString());
                LoadData();
            }
        }
    }
}
