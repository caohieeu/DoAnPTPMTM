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
    public partial class XuatHangForm : Form
    {
        private readonly Execute execute;
        private readonly string productId;
        public XuatHangForm(Execute execute, string productId)
        {
            InitializeComponent();
            this.execute = execute;
            this.productId = productId;
        }

        private void XuatHangForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = execute.GetGoodsIssue(productId);
        }
    }
}
