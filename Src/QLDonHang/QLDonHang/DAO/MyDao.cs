using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLDonHang.Models;
using QLDonHang.Model;

namespace QLLuongDuyet.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public DataSet GetDonHang()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            IDataParameter[] parameters = {
                new SqlParameter("@pUserID", SqlDbType.NVarChar) { Value = Core.Enviroment.UserID }
            };
            return myDbContext.ExecuteQueryDataset("GetOrder", CommandType.StoredProcedure, parameters);

        }
        public DataSet GetLuongDuyet(string orderid)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            IDataParameter[] parameters = {
                new SqlParameter("@pOrderId", SqlDbType.NVarChar) { Value = orderid }
            };

            return myDbContext.ExecuteQueryDataset("GetLuongDuyet", CommandType.StoredProcedure, parameters);   
        }
        public bool UpdateStatus(Orders order)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@porderid", SqlDbType.NVarChar, 50) { Value = order.Id },
                new SqlParameter("@pluongduyetid", SqlDbType.NVarChar, 50) { Value = order.OrderStatus },
                new SqlParameter("@pUserId", SqlDbType.NVarChar, 50) { Value = Core.Enviroment.UserID },
                new SqlParameter("@pOrderBrowseId", SqlDbType.NVarChar, 50) { Value = Guid.NewGuid().ToString() },
            };

            int res = myDbContext.ExecuteCommand("UpdateOrderStatus", CommandType.StoredProcedure, parameters);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public int GetStockProduct(string productId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT Stock FROM Products WHERE Id='" + productId + "'";

            DataTable resultTable = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);

            if(resultTable.Rows.Count > 0)
            {
                return Convert.ToInt32(resultTable.Rows[0]["Stock"]);
            }
            else
            {
                return 0;
            }
        }
        public bool UpdateStockProduct(string productId, int stock)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"UPDATE Products SET Stock = @Stock WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", productId),
                new SqlParameter("@Stock", stock),
            };
            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }
    }
}
