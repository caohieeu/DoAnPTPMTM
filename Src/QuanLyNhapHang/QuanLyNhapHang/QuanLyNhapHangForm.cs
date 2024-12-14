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
    public partial class QuanLyNhapHangForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;
        private DataTable childTable;
        public QuanLyNhapHangForm(string connectionString)
        {
            InitializeComponent();

            _connectionString = connectionString;
            gridMaster.DataSource = bsMaster;
            gridChild.DataSource = bsDetail;
        }

        private void QuanLyNhapHangForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            LoadData();
        }
        private void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);

            DataSet dts = myDao.GetAllNhapHang();
            masterTable = dts.Tables[0];
            childTable = dts.Tables[1];

            DataColumn[] cols = new DataColumn[] { masterTable.Columns["Id"] };
            DataColumn[] cols2 = new DataColumn[] { childTable.Columns["GoodsReceiptId"] };

            DataRelation dataRelation = new DataRelation("RL", cols, cols2, false);
            dts.Relations.Add(dataRelation);

            bsMaster.DataSource = dts;
            bsMaster.DataMember = masterTable.TableName;

            bsDetail.DataSource = bsMaster;
            bsDetail.DataMember = "RL";
            if (gridMaster.Columns.Count > 0)
            {
                gridMaster.Columns["chon"].HeaderText = "Chọn";
                gridMaster.Columns["Id"].HeaderText = "Mã Nhập Hàng";
                gridMaster.Columns["ProviderId"].HeaderText = "Mã Nhà Cung Cấp";
                gridMaster.Columns["ProviderName"].HeaderText = "Tên Nhà Cung Cấp";
                gridMaster.Columns["Address"].HeaderText = "Địa Chỉ";
                gridMaster.Columns["Phone"].HeaderText = "Số Điện Thoại";
                gridMaster.Columns["TotalShip"].HeaderText = "Tổng Tiền Vận Chuyển";
                gridMaster.Columns["TotalProduct"].HeaderText = "Tổng Sản Phẩm";
                gridMaster.Columns["TotalPrice"].HeaderText = "Tổng Tiền";
                gridMaster.Columns["CreatedDate"].HeaderText = "Ngày Tạo";
                gridMaster.Columns["CreatedUserId"].HeaderText = "Người Tạo";
            }

            if (gridChild.Columns.Count > 0)
            {
                gridChild.Columns["chon"].HeaderText = "Chọn";
                gridChild.Columns["Id"].HeaderText = "Mã Chi Tiết Nhập Hàng";
                gridChild.Columns["GoodsReceiptId"].HeaderText = "Mã Nhập Hàng";
                gridChild.Columns["ProductId"].HeaderText = "Mã Sản Phẩm";
                gridChild.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                gridChild.Columns["Quantity"].HeaderText = "Số Lượng";
                gridChild.Columns["Price"].HeaderText = "Giá";
                gridChild.Columns["Ship"].HeaderText = "Phí Vận Chuyển";
                gridChild.Columns["Status"].HeaderText = "Trạng Thái";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var msTable = masterTable.Clone();
            msTable.Columns.Remove("chon");

            var cTable = childTable.Clone();
            cTable.Columns.Remove("chon");

            var frm = new QLNHUpsertForm(_connectionString, 0, msTable, cTable);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (bsMaster.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = ((DataRowView)bsMaster.Current).Row;

            string goodsReceiptId = selectedRow["Id"].ToString();
            var inValid1 = childTable.AsEnumerable()
                .Any(row => row["GoodsReceiptId"].ToString() == goodsReceiptId 
                && (int)row["Status"] == 1);
            if(inValid1 )
            {
                MessageBox.Show("Đơn hàng đã từng được xuất không thể chỉnh sữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var childDt = childTable.Select($"GoodsReceiptId = '{goodsReceiptId}'").CopyToDataTable();
            childDt.Columns.Remove("chon");

            var msTable = selectedRow.Table.Clone();
            msTable.Columns.Remove("chon");
            msTable.ImportRow(selectedRow);

            var frm = new QLNHUpsertForm(_connectionString, 1, msTable, childDt);
            frm.ShowDialog();

            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                gridMaster.EndEdit();
                gridChild.EndEdit();

                var masterIds = masterTable.AsEnumerable()
                                .Where(row => (bool)row["chon"])
                                .Select(row => row["Id"].ToString());

                var inValid1 = childTable.AsEnumerable()
                 .Any(row => masterIds.Contains(row["GoodsReceiptId"].ToString()) && (int)row["Status"] == 1);
                var inValid2 = childTable.AsEnumerable()
                   .Any(row => (bool)row["chon"] && (int)row["Status"] == 1);
                if (inValid1 || inValid2)
                    MessageBox.Show("không thể xuất hàng nhập có status bằng 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var product1 = childTable.AsEnumerable()
                   .Where(row => masterIds.Contains(row["GoodsReceiptId"].ToString()) && (int)row["Status"] == 0)
                   .Select(row => new GoodsUpdateDto
                   {
                       Id = row["Id"].ToString(),
                       GoodsReceiptId = row["GoodsReceiptId"].ToString(),
                       ProductId = row["ProductId"].ToString(),
                       Quantity = (int)row["Quantity"]
                   })
                   .ToList();
                var product2 = childTable.AsEnumerable()
                   .Where(row => (bool)row["chon"] && (int)row["Status"] == 0)
                   .Select(row => new GoodsUpdateDto
                   {
                       Id = row["Id"].ToString(),
                       GoodsReceiptId = row["GoodsReceiptId"].ToString(),
                       ProductId = row["ProductId"].ToString(),
                       Quantity = (int)row["Quantity"]
                   })
                   .ToList();

                var products = product1
                    .Concat(product2)
                    .GroupBy(p => p.Id)
                    .Select(group => group.First())
                    .ToList();

                MyDao myDao = new MyDao(_connectionString);
                var updateForm = new UpdateProductsForm(myDao, products);
                updateForm.ShowDialog();
                if (updateForm.isSave)
                {
                    LoadData();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
