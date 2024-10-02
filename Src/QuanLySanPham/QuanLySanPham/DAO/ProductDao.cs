using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DAL;
using Microsoft.Data.SqlClient;
using QuanLySanPham.Model;

namespace QuanLySanPham.DAO
{
    public class ProductDao
    {
        string Conn;
        public ProductDao(string conn)
        {
            Conn = conn;
        }
        public DataTable GetData()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT * FROM Products";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }
        public bool InsertProduct(Product product)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"INSERT INTO Products (Id, Name, Description, Price, ImageURL, CategoryID, BrandID, DateCreated, DatePurchase, Stock) 
                        VALUES (@Id, @Name, @Description, @Price, @ImageURL, @CategoryID, @BrandID, @DateCreated, @DatePurchase, @Stock)";

            var parameters = new IDataParameter[]
            {
            new SqlParameter("@Id", product.Id),
            new SqlParameter("@Name", product.Name),
            new SqlParameter("@Description", product.Description),
            new SqlParameter("@Price", product.Price),
            new SqlParameter("@ImageURL", product.ImageURL),
            new SqlParameter("@CategoryID", product.CategoryID),
            new SqlParameter("@BrandID", product.BrandID),
            new SqlParameter("@DateCreated", product.DateCreated),
            new SqlParameter("@DatePurchase", product.DatePurchase),
            new SqlParameter("@Stock", product.Stock)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }

        public bool DeleteProduct(string id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = "DELETE FROM Products WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", id)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }
        public bool UpdateProduct(Product product)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            string sqlQuery = @"UPDATE Products 
                        SET Name = @Name, 
                            Description = @Description, 
                            Price = @Price, 
                            ImageURL = @ImageURL, 
                            CategoryID = @CategoryID, 
                            BrandID = @BrandID,
                            DateCreated = @DateCreated,
                            DatePurchase = @DatePurchase,
                            Stock = @Stock
                        WHERE Id = @Id";

            var parameters = new IDataParameter[]
            {
                new SqlParameter("@Id", product.Id),
                new SqlParameter("@Name", product.Name),
                new SqlParameter("@Description", product.Description),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@ImageURL", product.ImageURL),
                new SqlParameter("@CategoryID", product.CategoryID),
                new SqlParameter("@BrandID", product.BrandID),
                new SqlParameter("@DateCreated", product.DateCreated),
                new SqlParameter("@DatePurchase", product.DatePurchase),
                new SqlParameter("@Stock", product.Stock)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }


    }
}
