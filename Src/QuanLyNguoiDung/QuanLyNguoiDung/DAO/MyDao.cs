using Core.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoiDung.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public DataTable GetData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT * FROM Users";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }
        public bool Add(Users user)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"INSERT INTO Users(Id, UserName, PasswordHash, RoleId, Email, " +
                $"FullName, Address, Birth, Phone, ImagePath) " +
                $"values('{user.Id}', '{user.UserName}', '{user.Password}', '{user.RoleId}', " +
                $"'{user.Email}', '{user.FullName}', '{user.Address}', '{String.Format("{0:yyyy-MM-dd}", user.Birth)}', " +
                $"'{user.Password}', '{user.ImagePath}')";

            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);

            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public bool Update(Users user)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"UPDATE Users SET UserName='{user.UserName}', RoleId='{user.RoleId}', Email='{user.Email}', FullName='{user.FullName}', Address='{user.Address}', Birth='{String.Format("{0:yyyy-MM-dd}", user.Birth)}', Phone='{user.Phone}', ImagePath='{user.ImagePath}' WHERE Id='{user.Id}'";
            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);
            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(string userId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = $"DELETE FROM Users WHERE Id = '{userId}'";
            int res = myDbContext.ExecuteCommand(sqlQuery, CommandType.Text);
            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public Users GetUser(string userId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            Users users = new Users();
            string sqlQuery = $"SELECT * FROM Users WHERE Id = '{userId}'";

            var res = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                users = new Users
                {
                    UserName = row["UserName"].ToString(),
                    Password = row["PasswordHash"].ToString(),
                    RoleId = row["RoleId"].ToString(),
                    Email = row["Email"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Address = row["Address"].ToString(),
                    Birth = DateTime.Parse(row["Birth"].ToString()),
                    Phone = row["Phone"].ToString(),
                    ImagePath = row["ImagePath"].ToString()
                };
            }
            return users;
        }
        public List<Role> GetRoles()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            List<Role> roles = new List<Role>();
            string sqlQuery = $"SELECT * FROM Roles";

            var res = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
            if (res.Rows.Count > 0)
            {
                foreach (DataRow row in res.Rows)
                {
                    Role role = new Role
                    {
                        Id = row["Id"].ToString(),
                        Name = row["Name"].ToString(),
                    };

                    roles.Add(role);
                }
            }
            return roles;
        }
    }
}
