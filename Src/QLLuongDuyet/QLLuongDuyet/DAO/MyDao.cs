﻿using Core.DAL;
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

            return myDbContext.ExecuteQueryDataset("GetLuongDuyetRelate", CommandType.StoredProcedure);

        }
        public DataTable GetUsers()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string query = "select * from Users where RoleId = 'admin' or RoleId = 'employee'";
            return myDbContext.ExecuteQuery(query, CommandType.Text);   
        }
        public DataTable GetRole()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string query = "select * from Roles";
            return myDbContext.ExecuteQuery(query, CommandType.Text);
        }
        public bool UpdateRLD(RoleLuongDuyet roleLuongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"UPDATE [dbo].[RoleLuongDuyet]
                        SET [LuongDuyetId] = @LuongDuyetId, 
                            [RoleId] = @RoleId
                        WHERE [Id] = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = roleLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = roleLuongDuyet.LuongDuyetId },
                new SqlParameter("@RoleId", SqlDbType.NVarChar, 128) { Value = roleLuongDuyet.RoleId },
            };

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public bool AddRLD(RoleLuongDuyet roleLuongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"INSERT INTO [dbo].[RoleLuongDuyet]
                        ([Id], [LuongDuyetId], [RoleId])
                        VALUES
                        (@Id, @LuongDuyetId, @RoleId)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = roleLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = roleLuongDuyet.LuongDuyetId },
                new SqlParameter("@RoleId", SqlDbType.NVarChar, 128) { Value = roleLuongDuyet.RoleId },
            };

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters);

            if (res > 0)
            {
                return true;
            }

            return false;
        }
        public bool AddUSLD(UserLuongDuyet userLuongDuyet)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"INSERT INTO [dbo].[UserLuongDuyet]
                        ([Id], [LuongDuyetId], [UserId])
                        VALUES
                        (@Id, @LuongDuyetId, @UserId)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.LuongDuyetId },
                new SqlParameter("@UserId", SqlDbType.NVarChar, 128) { Value = userLuongDuyet.UserId },
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
                            [UserId] = @UserId
                        WHERE [Id] = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.Id },
                new SqlParameter("@LuongDuyetId", SqlDbType.NVarChar, 50) { Value = userLuongDuyet.LuongDuyetId },
                new SqlParameter("@UserId", SqlDbType.NVarChar, 128) { Value = userLuongDuyet.UserId },
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
