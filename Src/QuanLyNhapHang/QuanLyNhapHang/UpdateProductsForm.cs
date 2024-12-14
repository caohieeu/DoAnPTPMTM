using QuanLyNhapHang.DAO;
using QuanLyNhapHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapHang
{
    public partial class UpdateProductsForm : Form
    {
        List<string> GoodsReceiptId;
        List<ProductUpdateDto> ProcIds;
        MyDao myDao;
        public UpdateProductsForm(
            MyDao myDao,
            List<string> goodsReceiptId,
            List<ProductUpdateDto> procIds
        )
        {
            InitializeComponent();
            this.myDao = myDao;
            this.GoodsReceiptId = goodsReceiptId;
            this.ProcIds = procIds;
        }

        private void UpdateProductsForm_Load(object sender, EventArgs e)
        {
            var allProducts = myDao.GetProduct();

            var filteredProducts = allProducts.AsEnumerable()
                .Where(row => ProcIds.Any(x => x.Id == row["Id"]))
                .CopyToDataTable();

            dataGridView1.DataSource = filteredProducts; 
        }
    }
}
