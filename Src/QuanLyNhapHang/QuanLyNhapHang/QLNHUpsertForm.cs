using Core.DAL;
using Microsoft.Data.SqlClient;
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
using System.Xml.Linq;

namespace QuanLyNhapHang
{
    public partial class QLNHUpsertForm : Form
    {
        public bool IsSave { set; get; }
        string conn;
        int mode;
        DataTable masterData, detailData;
        MyDao myDao;
        DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
        bool isInit = true;
        public QLNHUpsertForm()
        {
            InitializeComponent();
        }
        public QLNHUpsertForm(
            string Conn
            , int mode
            , DataTable bsMaster = null
            , DataTable bsDetail = null
        )
        {
            if (DesignMode) return;

            InitializeComponent();
            this.conn = Conn;
            this.mode = mode;
            IsSave = false;
            this.masterData = bsMaster;
            this.detailData = bsDetail;

            detailGrid.DataSource = detailData;
            myDao = new MyDao(conn);
            UpdateShipTotal();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtNccId.Text == string.Empty
               || txtTong.Text == "0"
               )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var goods = new Models.GoodsReceipt
            {
                Id = Guid.NewGuid().ToString().Substring(0, 20),
                ProviderId = txtNccId.Text,
                ProviderName = txtNccName.Text,
                Address = txtdiachi.Text,
                Phone = txtsdt.Text,
                CreatedDate = DateTime.Now,
                CreatedUserId = Core.Enviroment.UserID,
                TotalPrice = decimal.Parse(txtTong.Text),
                TotalShip = decimal.Parse(txtTongShip.Text),
                TotalProduct = decimal.Parse(txtTongSp.Text),
            };
            MyDao myDao = new MyDao(conn);
            if (mode == 0)
            {
                myDao.InsertGoodsReceipt(goods);
            }
            else if (mode == 1)
            {
                goods.Id = masterData.Rows[0]["id"].ToString();
                myDao.UpdateNhapHang(goods);
                myDao.DeleteGoodsReceiptDetail(goods.Id);
            }
            InsertGoodsDetails(goods.Id);
            IsSave = true;
            Close();
        }
        private void InsertGoodsDetails(string goodsReceiptId)
        {
            foreach (DataRow row in detailData.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    var detail = new Models.GoodsReceiptDetail
                    {
                        Id = Guid.NewGuid().ToString().Substring(0, 20),
                        GoodsReceiptId = goodsReceiptId,
                        ProductId = row["ProductId"].ToString(),
                        ProductName = row["ProductName"].ToString(),
                        Quantity = int.Parse(row["Quantity"].ToString()),
                        Price = decimal.Parse(row["Price"].ToString()),
                        Status = int.Parse(row["Status"].ToString()),
                        Ship = decimal.Parse(row["Ship"].ToString())
                    };
                    myDao.InsertGoodsReceiptDetail(detail);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QLNHUpsertForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            txtNccId.DataSource = myDao.GetProvider();
            txtNccId.ValueMember = "Id";
            txtNccId.DisplayMember = "Id";

            if (masterData.Rows.Count > 0)
                txtNccId.SelectedValue = masterData.Rows[0]["ProviderId"].ToString();
            else
                txtNccId.SelectedValue = "";

            detailGrid.Columns["Id"].Visible = false;
            detailGrid.Columns["GoodsReceiptId"].Visible = false;
            detailGrid.Columns["Status"].ReadOnly = true;
            detailGrid.Columns["ProductName"].ReadOnly = true;

            comboColumn.DataSource = myDao.GetProduct(txtNccId.Text);
            AddGridComboBoxColumns(comboColumn, "ProductId", "Id");

            isInit = false;
        }

        private void AddGridComboBoxColumns(DataGridViewComboBoxColumn comboColumn, string colName, string colValue)
        {
            comboColumn.HeaderText = colName;
            comboColumn.Name = colName;
            comboColumn.DataPropertyName = colName;
            comboColumn.DisplayMember = colValue;
            comboColumn.ValueMember = colValue;

            int columnIndex = detailGrid.Columns[colName].Index;
            detailGrid.Columns.RemoveAt(columnIndex);
            detailGrid.Columns.Insert(columnIndex, comboColumn);
        }
        private void txtNccId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInit && mode == 0)
            {
                return;
            }
            var selectedProvider = txtNccId.SelectedItem as DataRowView;
            if (selectedProvider != null)
            {
                txtNccName.Text = selectedProvider["Name"].ToString();
                txtdiachi.Text = selectedProvider["Address"].ToString();
                txtsdt.Text = selectedProvider["Phone"].ToString();

                UpdateColumnDataSource("ProductId", txtNccId.Text);
            }
        }
        private void UpdateColumnDataSource(string columnName, string providerId)
        {
            var column = detailGrid.Columns[columnName] as DataGridViewComboBoxColumn;
            if (column != null)
            {
                var productData = myDao.GetProduct(providerId);
                column.DataSource = productData;
            }
        }
        private void detailGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == detailGrid.Columns["ProductId"].Index)
            {
                var selectedProductId = detailGrid.Rows[e.RowIndex].Cells["ProductId"].Value;
                var productDataSource = (DataTable)comboColumn.DataSource;

                var selectedProductRow = productDataSource.AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("Id") == selectedProductId);

                if (selectedProductRow != null)
                {
                    var productName = selectedProductRow.Field<string>("Name");
                    var productName2 = selectedProductRow.Field<string>("Id");
                    detailGrid.Rows[e.RowIndex].Cells["ProductName"].Value = productName;
                    detailGrid.Rows[e.RowIndex].Cells["ProductId"].Value = productName2;
                }
            }
            else if (e.ColumnIndex == detailGrid.Columns["Ship"].Index)
            {
                decimal totalShip = 0;

                foreach (DataGridViewRow row in detailGrid.Rows)
                {
                    if (row.Cells["Ship"].Value != null &&
                        decimal.TryParse(row.Cells["Ship"].Value.ToString(), out decimal shipValue))
                    {
                        totalShip += shipValue;
                    }
                }
                txtTongShip.Text = totalShip.ToString("F2");
                txtTong.Text = (decimal.Parse(txtTongShip.Text) + decimal.Parse(txtTongSp.Text)).ToString("F2");
            }
            else if (e.ColumnIndex == detailGrid.Columns["Price"].Index)
            {
                decimal totalShip = 0;

                foreach (DataGridViewRow row in detailGrid.Rows)
                {
                    if (row.Cells["Price"].Value != null &&
                        decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal shipValue))
                    {
                        totalShip += shipValue;
                    }
                }
                txtTongSp.Text = totalShip.ToString("F2");
                txtTong.Text = (decimal.Parse(txtTongShip.Text) + decimal.Parse(txtTongSp.Text)).ToString("F2");
            }
        }

        private void detailGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Status"].Value = "0";
            e.Row.Cells["Ship"].Value = decimal.Parse("0");
            e.Row.Cells["Price"].Value = decimal.Parse("0");
        }
        private void UpdateShipTotal()
        {
            decimal resShip = 0, resPro = 0;
            foreach (DataRow row in detailData.Rows)
            {
                resShip += (decimal)row["Ship"];
                resPro += (decimal)row["Price"];
            }
            txtTongShip.Text = resShip.ToString("F2");
            txtTongSp.Text = resPro.ToString("F2");
            txtTong.Text = (decimal.Parse(txtTongShip.Text) + decimal.Parse(txtTongSp.Text)).ToString("F2");
        }

        private void detailGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateShipTotal();
        }
    }
}
