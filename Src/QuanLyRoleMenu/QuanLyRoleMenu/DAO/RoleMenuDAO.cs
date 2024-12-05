using Core.DAL;
using Microsoft.Data.SqlClient;
using QuanLyRoleMenu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRoleMenu.DAO
{
    public class RoleMenuDao
    {
        private string Conn;
        public RoleMenuDao(string conn)
        {
            Conn = conn;
        }

        public DataTable GetData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM RoleMenu";
            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

        public bool InsertRoleMenu(RoleMenu roleMenu)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "INSERT INTO RoleMenu (RoleId, MenuId) VALUES (@RoleId, @MenuId)";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@RoleId", roleMenu.RoleId),
                new SqlParameter("@MenuId", roleMenu.MenuId)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool DeleteRoleMenu(string roleId, string menuId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM RoleMenu WHERE RoleId = @RoleId AND MenuId = @MenuId";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@RoleId", roleId),
                new SqlParameter("@MenuId", menuId)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public DataTable GetRoleMenuByRoleId(string roleId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"SELECT * FROM RoleMenu WHERE RoleId = @RoleId";
            var parameters = new IDataParameter[]
            {
                new SqlParameter("@RoleId", roleId)
            };

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
        }
    }

}
