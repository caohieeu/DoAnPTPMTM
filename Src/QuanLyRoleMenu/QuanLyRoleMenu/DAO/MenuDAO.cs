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
    public class MenuDao
    {
        private string Conn;
        public MenuDao(string conn)
        {
            Conn = conn;
        }

        public DataTable GetData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM Menu";
            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

        public bool InsertMenu(Menu menu)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"INSERT INTO Menu (MenuId, AssemblyName, NameSpace, MenuName) 
                            VALUES (@MenuId, @AssemblyName, @NameSpace, @MenuName)";

            var parameters = new IDataParameter[]
            {
            new SqlParameter("@MenuId", menu.MenuId),
            new SqlParameter("@AssemblyName", menu.AssemblyName),
            new SqlParameter("@NameSpace", menu.NameSpace),
            new SqlParameter("@MenuName", menu.MenuName)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool UpdateMenu(Menu menu)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"UPDATE Menu
                            SET AssemblyName = @AssemblyName, 
                                NameSpace = @NameSpace, 
                                MenuName = @MenuName 
                            WHERE MenuId = @MenuId";

            var parameters = new IDataParameter[]
            {
            new SqlParameter("@MenuId", menu.MenuId),
            new SqlParameter("@AssemblyName", menu.AssemblyName),
            new SqlParameter("@NameSpace", menu.NameSpace),
            new SqlParameter("@MenuName", menu.MenuName)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool DeleteMenu(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM Menu WHERE MenuId = @MenuId";

            var parameters = new IDataParameter[]
            {
            new SqlParameter("@MenuId", id)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public DataTable GetMenuByRoleId(string roleId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"
            SELECT m.MenuId, m.AssemblyName, m.NameSpace, m.MenuName
            FROM Menu m
            INNER JOIN RoleMenu rm ON m.MenuId = rm.MenuId
            WHERE rm.RoleId = @RoleId";

            var parameters = new IDataParameter[]
            {
            new SqlParameter("@RoleId", roleId)
            };

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
        }
    }

}
