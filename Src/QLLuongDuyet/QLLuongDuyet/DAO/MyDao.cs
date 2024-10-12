using Core.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using QLLuongDuyet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLuongDuyet.DAO
{
    public class MyDao
    {
        string Conn;
        public MyDao(string conn)
        {
            Conn = conn;
        }
        public DataTable GetLuongDuyet()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "select * from LuongDuyet order by ThuTu";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
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
