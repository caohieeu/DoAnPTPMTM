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
        }

        private void QLNDForm_Load(object sender, EventArgs e)
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
