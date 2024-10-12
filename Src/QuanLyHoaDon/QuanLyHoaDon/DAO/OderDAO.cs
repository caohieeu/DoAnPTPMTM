using Core.DAL;
using QuanLyHoaDon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Core.DAL;
using QuanLyHoaDon.Model;


namespace QuanLyHoaDon.DAO
{
    public class OrderDao
    {
        private string Conn;

        public OrderDao(string conn)
        {
            Conn = conn;
        }

        // Lấy tất cả dữ liệu từ bảng Orders
        public DataTable GetOrders()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM Orders";
            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

        // Thêm mới một Order
        public bool InsertOrder(Order order)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"INSERT INTO Orders (Id, UserID, ShippingAddress, PaymentMethod, OrderStatus, DeliveryStatus, OrderDate) 
                                VALUES (@Id, @UserID, @ShippingAddress, @PaymentMethod, @OrderStatus, @DeliveryStatus, @OrderDate)";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", order.Id),
                new SqlParameter("@UserID", order.UserID),
                new SqlParameter("@ShippingAddress", order.ShippingAddress),
                new SqlParameter("@PaymentMethod", order.PaymentMethod),
                new SqlParameter("@OrderStatus", order.OrderStatus),
                new SqlParameter("@DeliveryStatus", order.DeliveryStatus),
                new SqlParameter("@OrderDate", order.OrderDate)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Cập nhật một Order
        public bool UpdateOrder(Order order)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"UPDATE Orders 
                                SET UserID = @UserID, 
                                    ShippingAddress = @ShippingAddress, 
                                    PaymentMethod = @PaymentMethod, 
                                    OrderStatus = @OrderStatus, 
                                    DeliveryStatus = @DeliveryStatus, 
                                    OrderDate = @OrderDate
                                WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", order.Id),
                new SqlParameter("@UserID", order.UserID),
                new SqlParameter("@ShippingAddress", order.ShippingAddress),
                new SqlParameter("@PaymentMethod", order.PaymentMethod),
                new SqlParameter("@OrderStatus", order.OrderStatus),
                new SqlParameter("@DeliveryStatus", order.DeliveryStatus),
                new SqlParameter("@OrderDate", order.OrderDate)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Xóa một Order theo Id
        public bool DeleteOrder(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM Orders WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Lấy Order theo Id
        public Order GetOrderById(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM Orders WHERE Id = @Id";
            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            var result = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Order
                {
                    Id = row["Id"].ToString(),
                    UserID = row["UserID"].ToString(),
                    ShippingAddress = row["ShippingAddress"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString(),
                    OrderStatus = row["OrderStatus"].ToString(),
                    DeliveryStatus = row["DeliveryStatus"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"])
                };
            }
            return null;
        }

    }
}
