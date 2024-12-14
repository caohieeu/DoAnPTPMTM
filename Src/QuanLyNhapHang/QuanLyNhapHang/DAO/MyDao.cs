using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyNhapHang.Models;

namespace QuanLyNhapHang.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public bool UpdateGoodsStatus(string grId, string procId, int stock, decimal price)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@pGRId", SqlDbType.NVarChar, 128) { Value = grId },
                new SqlParameter("@pProcId", SqlDbType.NVarChar, 128) { Value = procId },
                new SqlParameter("@pStock", SqlDbType.NVarChar, 256) { Value = stock },
                new SqlParameter("@pPrice", SqlDbType.NVarChar) { Value = price }
            };
            int res = myDbContext.ExecuteCommand("UpdateGoodsStatus", CommandType.StoredProcedure, parameters);
            return res > 0;
        }
        public DataTable GetProduct(string providerId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = $"SELECT * FROM Products where providerId = '{providerId}'";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }
        public DataTable GetProduct()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = $"SELECT * FROM Products";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }
        public DataTable GetProvider()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            return myDbContext.ExecuteQuery("GetProvider", CommandType.StoredProcedure);
        }
        public DataSet GetAllNhapHang()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            return myDbContext.ExecuteQueryDataset("GetAllGoodsReceipts", CommandType.StoredProcedure);

        }
        public bool UpdateNhapHang(GoodsReceipt receipt)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 128) { Value = receipt.Id },
                new SqlParameter("@ProviderId", SqlDbType.NVarChar, 128) { Value = receipt.ProviderId },
                new SqlParameter("@ProviderName", SqlDbType.NVarChar, 256) { Value = receipt.ProviderName ?? (object)DBNull.Value },
                new SqlParameter("@Address", SqlDbType.NVarChar) { Value = receipt.Address ?? (object)DBNull.Value }, // -1 for NVARCHAR(MAX)
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = receipt.Phone ?? (object)DBNull.Value },
                new SqlParameter("@TotalShip", SqlDbType.Decimal) { Value = receipt.TotalShip },
                new SqlParameter("@TotalProduct", SqlDbType.Decimal) { Value = receipt.TotalProduct },
                new SqlParameter("@TotalPrice", SqlDbType.Decimal) { Value = receipt.TotalPrice },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = receipt.CreatedDate },
                new SqlParameter("@CreatedUserId", SqlDbType.NVarChar, 128) { Value = receipt.CreatedUserId }
            };

            int res = myDbContext.ExecuteCommand("UpdateGoodsReceipt", CommandType.StoredProcedure, parameters);

            return res > 0;
        }
        public bool DeleteGoodsReceipt(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 128) { Value = id }
            };

            int res = myDbContext.ExecuteCommand("DeleteGoodsReceipt", CommandType.StoredProcedure, parameters);

            return res > 0;
        }
        public bool InsertGoodsReceipt(GoodsReceipt receipt)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 128) { Value = receipt.Id },
                new SqlParameter("@ProviderId", SqlDbType.NVarChar, 128) { Value = receipt.ProviderId },
                new SqlParameter("@ProviderName", SqlDbType.NVarChar, 256) { Value = receipt.ProviderName ?? (object)DBNull.Value },
                new SqlParameter("@Address", SqlDbType.NVarChar, -1) { Value = receipt.Address ?? (object)DBNull.Value }, // -1 for NVARCHAR(MAX)
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = receipt.Phone ?? (object)DBNull.Value },
                new SqlParameter("@TotalShip", SqlDbType.Decimal) { Value = receipt.TotalShip },
                new SqlParameter("@TotalProduct", SqlDbType.Decimal) { Value = receipt.TotalProduct },
                new SqlParameter("@TotalPrice", SqlDbType.Decimal) { Value = receipt.TotalPrice },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = receipt.CreatedDate },
                new SqlParameter("@CreatedUserId", SqlDbType.NVarChar, 128) { Value = receipt.CreatedUserId }
            };

            int res = myDbContext.ExecuteCommand("InsertGoodsReceipt", CommandType.StoredProcedure, parameters);

            return res > 0;
        }
        public bool DeleteGoodsReceiptDetail(string goodsReceiptId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@pGoodsReceiptId", SqlDbType.NVarChar, 128) { Value = goodsReceiptId }
            };

            int res = myDbContext.ExecuteCommand("DeleteGoodsReceiptDetail", CommandType.StoredProcedure, parameters);

            return res > 0;
        }

        public bool InsertGoodsReceiptDetail(GoodsReceiptDetail detail)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 128) { Value = detail.Id },
                new SqlParameter("@GoodsReceiptId", SqlDbType.NVarChar, 128) { Value = detail.GoodsReceiptId },
                new SqlParameter("@ProductId", SqlDbType.NVarChar, 128) { Value = detail.ProductId },
                new SqlParameter("@ProductName", SqlDbType.NVarChar, 256) { Value = detail.ProductName ?? string.Empty },
                new SqlParameter("@Quantity", SqlDbType.Int) { Value = detail.Quantity },
                new SqlParameter("@Price", SqlDbType.Decimal) { Value = detail.Price },
                new SqlParameter("@Ship", SqlDbType.Decimal) { Value = detail.Ship },
                new SqlParameter("@Status", SqlDbType.Int) { Value = detail.Status }
            };

            int res = myDbContext.ExecuteCommand("InsertGoodsReceiptDetail", CommandType.StoredProcedure, parameters);

            return res > 0;
        }
    }
}
