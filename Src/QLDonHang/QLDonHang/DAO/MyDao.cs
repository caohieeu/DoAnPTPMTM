using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLDonHang.Models;

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
        public DataTable GetLuongDuyet()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string query = "select ld.* from LuongDuyet ld " +
                            "left join UserLuongDuyet us on ld.Id = us.LuongDuyetId " +
                            "order by ThuTu";
            return myDbContext.ExecuteQuery(query, CommandType.Text);   
        }
        public bool UpdateStatus(Orders order)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"UPDATE [dbo].[Orders]
                        SET [OrderStatus] = @OrderStatus
                        WHERE [Id] = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = order.Id },
                new SqlParameter("@OrderStatus", SqlDbType.NVarChar, 50) { Value = order.OrderStatus },
            };

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
    }
}
