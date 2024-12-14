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
        List<GoodsUpdateDto> ProcIds;
        MyDao myDao;
        public UpdateProductsForm(
            MyDao myDao,
            List<GoodsUpdateDto> procIds
        )
        {
            InitializeComponent();
            this.myDao = myDao;
            this.ProcIds = procIds;
        }

        private void UpdateProductsForm_Load(object sender, EventArgs e)
        {
            var allProducts = myDao.GetProduct();

            var filteredProducts1 = allProducts.AsEnumerable()
                .Where(row => ProcIds.Any(x => x.ProductId == row["Id"].ToString()))
                .Select(row => new ProductsUpdateDto
                {
                    Id = row["Id"].ToString(),
                    Price = (decimal)row["Price"],
                    Stock = (int)row["Stock"],
                    Name = row["Name"].ToString()
                }).ToList();

            var filteredProducts2 = allProducts.AsEnumerable()
                .Where(row => ProcIds.Any(x => x.ProductId == row["Id"].ToString()))
                .Select(row =>
                {
                    var productId = row["Id"].ToString();
                    var additionalStock = ProcIds
                        .Where(x => x.ProductId == productId)
                        .Sum(x => x.Quantity);
                    return new ProductsUpdateDto
                    {
                        Id = productId,
                        Price = (decimal)row["Price"],
                        Stock = (int)row["Stock"] + additionalStock,
                        Name = row["Name"].ToString()
                    };
                }).ToList();

            dataGridView1.DataSource = filteredProducts1;
            dataGridView2.DataSource = filteredProducts2;

            string readOnlyCol = "Id,Name,Stock";
            foreach (var col in readOnlyCol.Split(','))
            {
                dataGridView2.Columns[col].ReadOnly = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var listProc = dataGridView2.DataSource as List<ProductsUpdateDto>;
            foreach(var proc in ProcIds)
            {
                foreach(var productUpdate in listProc.Where(x => x.Id == proc.ProductId))
                {
                    myDao.UpdateGoodsStatus(proc.GoodsReceiptId, proc.ProductId, productUpdate.Stock, productUpdate.Price);    
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
