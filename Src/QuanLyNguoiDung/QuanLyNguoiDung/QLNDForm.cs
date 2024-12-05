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
                MyDao myDao = new MyDao(_connectionString);
                DataTable dt = myDao.GetData();
                grdUser.DataSource = dt;
            }
        }
    }
}
