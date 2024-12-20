﻿using QuanLyNhapHang.DAO;
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
        public bool isSave { set; get; } = false;
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
                })
                .OrderBy(x => x.Id)
                .ToList();

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
                })
                .OrderBy(x => x.Id)
                .ToList();

            dataGridView1.DataSource = filteredProducts1;
            dataGridView2.DataSource = filteredProducts2;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].HeaderText = "Mã Sảm Phẩm";
                dataGridView1.Columns["Name"].HeaderText = "Tên Sản Phẩm";
                dataGridView1.Columns["Stock"].HeaderText = "Số Lượng";
                dataGridView1.Columns["Price"].HeaderText = "Giá";
            }
            if (dataGridView2.Columns.Count > 0)
            {
                dataGridView2.Columns["Id"].HeaderText = "Mã Sảm Phẩm";
                dataGridView2.Columns["Name"].HeaderText = "Tên Sản Phẩm";
                dataGridView2.Columns["Stock"].HeaderText = "Số Lượng";
                dataGridView2.Columns["Price"].HeaderText = "Giá";
            }

            string readOnlyCol = "Id,Name,Stock";
            foreach (var col in readOnlyCol.Split(','))
            {
                dataGridView2.Columns[col].ReadOnly = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var listProc2 = dataGridView2.DataSource as List<ProductsUpdateDto>;
            var listProc1 = dataGridView1.DataSource as List<ProductsUpdateDto>;
            foreach (var proc in ProcIds)
            {
                var proc1 = listProc1.Where(x => x.Id == proc.ProductId).SingleOrDefault();
                var proc2= listProc2.Where(x => x.Id == proc.ProductId).SingleOrDefault();

                myDao.UpdateGoodsStatus(proc.GoodsReceiptId
                    , proc.ProductId
                    , proc1.Price
                    , proc1.Stock
                    , proc2.Price
                    , proc2.Stock
                    , Core.Enviroment.UserID);
            }
            MessageBox.Show("Luu thanh cong");
            isSave = true;
            Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
