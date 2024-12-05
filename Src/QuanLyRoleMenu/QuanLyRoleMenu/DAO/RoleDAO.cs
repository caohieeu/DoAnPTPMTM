using Core.DAL;
using QuanLyRoleMenu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using Core.DAL;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyRoleMenu.DAO
{
    public class RoleDao
    {
        private string Conn;
        public RoleDao(string conn)
        {
            Conn = conn;
        }

        public DataTable GetData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM Roles";
            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

        public bool InsertRole(Role role)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "INSERT INTO Roles (Id, Name) VALUES (@Id, @Name)";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", role.Id),
                new SqlParameter("@Name", role.Name)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool UpdateRole(Role role)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "UPDATE Roles SET Name = @Name WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", role.Id),
                new SqlParameter("@Name", role.Name)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool DeleteRole(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM Roles WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }
    }
}
