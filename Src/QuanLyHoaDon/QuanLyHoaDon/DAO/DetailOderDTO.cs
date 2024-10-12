using Core.DAL;
using Microsoft.Data.SqlClient;
using QuanLyHoaDon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.DAO
{
    public class OrderDetailDao
    {
        private string Conn;

        public OrderDetailDao(string conn)
        {
            Conn = conn;
        }

        // Lấy tất cả chi tiết đơn hàng theo OrderId
        public DataTable GetOrderDetailsByOrderId(string orderId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM OrderDetails WHERE OrderId = @OrderId";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@OrderId", orderId)
            };

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
        }

        // Thêm mới một chi tiết đơn hàng
        public bool InsertOrderDetail(OrderDetail orderDetail)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"INSERT INTO OrderDetails (Id, OrderId, ProductId, Quantity, Price) 
                                VALUES (@Id, @OrderId, @ProductId, @Quantity, @Price)";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", orderDetail.Id),
                new SqlParameter("@OrderId", orderDetail.OrderId),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@Quantity", orderDetail.Quantity),
                new SqlParameter("@Price", orderDetail.Price)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Cập nhật chi tiết đơn hàng
        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"UPDATE OrderDetails 
                                SET ProductId = @ProductId, 
                                    Quantity = @Quantity, 
                                    Price = @Price
                                WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", orderDetail.Id),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@Quantity", orderDetail.Quantity),
                new SqlParameter("@Price", orderDetail.Price)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Xóa chi tiết đơn hàng theo Id
        public bool DeleteOrderDetail(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM OrderDetails WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        // Lấy chi tiết đơn hàng theo Id
        public OrderDetail GetOrderDetailById(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "SELECT * FROM OrderDetails WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            var result = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new OrderDetail
                {
                    Id = row["Id"].ToString(),
                    OrderId = row["OrderId"].ToString(),
                    ProductId = row["ProductId"].ToString(),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    Price = Convert.ToDecimal(row["Price"])
                };
            }
            return null;
        }
        // Hàm tính tổng giá của OrderDetail theo OrderId
        public decimal GetTotalPriceByOrderId(string orderId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"
                                SELECT SUM(Quantity * Price) AS TotalPrice 
                                FROM OrderDetails 
                                WHERE OrderId = @OrderId";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@OrderId", orderId)
            };
            var result = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
            if (result.Rows.Count > 0 && result.Rows[0]["TotalPrice"] != DBNull.Value)
            {
                return Convert.ToDecimal(result.Rows[0]["TotalPrice"]);
            }
            return 0;
        }
    }
}
