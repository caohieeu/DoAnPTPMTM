using Core.DAL;
using QLLuongDuyet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLLuongDuyet.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public DataSet GetLuongDuyet()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string query = "select * from LuongDuyet order by ThuTu " +
                            "select * from UserLuongDuyet";
            return myDbContext.ExecuteQueryDataset(query, CommandType.Text);

        }
        public DataTable GetUsers()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string query = "select * from Users where RoleId = 'admin' or RoleId = 'employee'";
            return myDbContext.ExecuteQuery(query, CommandType.Text);   
        }
        public DataTable GetOrders()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
          
            string query = "select * from Users where RoleId = 'admin' or RoleId = 'employee'";
            return myDbContext.ExecuteQuery(query, CommandType.Text);
        }
        public bool AddUSLD(UserLuongDuyet userLuongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"INSERT INTO [dbo].[UserLuongDuyet]
                        ([Id], [LuongDuyetId], [UserId], [OrderId])
                        VALUES
                        (@Id, @LuongDuyetId, @UserId, @OrderId)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.LuongDuyetId },
                new SqlParameter("@UserId", SqlDbType.NVarChar, 128) { Value = userLuongDuyet.UserId },
                new SqlParameter("@OrderId", SqlDbType.NVarChar, 128) { Value = (object)userLuongDuyet.OrderId ?? DBNull.Value }
            };

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);

            if (res > 0)
            {
                return true;
            }

            return false;
        }
        public bool UpdateUSLD(UserLuongDuyet userLuongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"UPDATE [dbo].[UserLuongDuyet]
                        SET [LuongDuyetId] = @LuongDuyetId, 
                            [UserId] = @UserId, 
                            [OrderId] = @OrderId
                        WHERE [Id] = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.LuongDuyetId },
                new SqlParameter("@UserId", SqlDbType.NVarChar, 128) { Value = userLuongDuyet.UserId },
                new SqlParameter("@OrderId", SqlDbType.NVarChar, 128) { Value = userLuongDuyet.OrderId }
            };

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);

            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddLuongDuyet(LuongDuyet luongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"INSERT INTO [dbo].[LuongDuyet] " +
                              $"([Id], [TenLuongDuyet], [ThuTu]) " +
                              $"VALUES ('{luongDuyet.Id}', '{luongDuyet.TenLuongDuyet}', {luongDuyet.ThuTu})";

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);

            if (res > 0)
            {
                return true;
            }
            return false;

        }
        public bool UpdateLuongDuyet(LuongDuyet luongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"UPDATE [dbo].[LuongDuyet] " +
                              $"SET [TenLuongDuyet] = '{luongDuyet.TenLuongDuyet}', " +
                              $"[ThuTu] = {luongDuyet.ThuTu} " +
                              $"WHERE [Id] = '{luongDuyet.Id}'";

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteLuongDuyet(string luongDuyetId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"DELETE FROM LuongDuyet WHERE Id = '{luongDuyetId}'";
            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);
            if (res > 0)
            {
                return true;
            }
            return false;
        }
    }
}
