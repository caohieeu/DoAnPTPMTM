using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyNCC.Models;

namespace QuanLyNCC.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public DataSet GetProvider()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            return myDbContext.ExecuteQueryDataset("GetProvider", CommandType.StoredProcedure);
        }
        public bool UpdateProvider(Provider provider)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            SqlParameter[] parameters =
            {
                new SqlParameter("@pId", SqlDbType.NVarChar, 128) { Value = provider.Id },
                new SqlParameter("@pName", SqlDbType.NVarChar, 256) { Value = provider.Name },
                new SqlParameter("@pAddress", SqlDbType.NVarChar) { Value = provider.Address },
                new SqlParameter("@pPhone", SqlDbType.NVarChar, 20) { Value = provider.Phone },
            };

            int res = myDbContext.ExecuteCommand("UpdateProvider", CommandType.StoredProcedure, parameters);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public bool AddProvider(Provider provider)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"
                INSERT INTO [dbo].[Provider]
                ([Id], [Name], [Address], [Phone])
                VALUES
                (@Id, @Name, @Address, @Phone)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = provider.Id },
                new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = provider.Name ?? (object)DBNull.Value },
                new SqlParameter("@Address", SqlDbType.NVarChar, 200) { Value = provider.Address ?? (object)DBNull.Value },
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = provider.Phone ?? (object)DBNull.Value }
            };
            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);
            return res > 0;
        }

    }
}
