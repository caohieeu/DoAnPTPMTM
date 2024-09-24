using Core.DAL;
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
    }
}
