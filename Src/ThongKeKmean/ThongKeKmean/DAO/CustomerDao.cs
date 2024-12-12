using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThongKeKmean.MODEL;
using Core.DAL;
using Microsoft.Data.SqlClient;

namespace ThongKeKmean.DAO
{
    public class CustomerDao
    {
        string Conn;

        public CustomerDao(string conn)
        {
            Conn = conn;
        }

        public DataTable GetCustomerPurchaseData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = @"
                                SELECT 
                                    u.Id AS UserId,
                                    u.FullName,
                                    u.Email,
                                    u.Address,
                                    YEAR(GETDATE()) - YEAR(u.Birth) AS Age,
                                    SUM(od.Quantity * od.Price) AS TotalPurchaseAmount
                                FROM 
                                    Users u
                                JOIN 
                                    Orders o ON u.Id = o.UserId
                                JOIN 
                                    OrderDetails od ON o.Id = od.OrderId
                                GROUP BY 
                                    u.Id, u.FullName, u.Email, u.Address, u.Birth";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

    }
}
