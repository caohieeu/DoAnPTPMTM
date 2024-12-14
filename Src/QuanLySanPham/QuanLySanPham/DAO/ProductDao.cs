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
        public DataTable GetGoodsIssue(string productId)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = $"SELECT * FROM GoodsIssue where productId = '{productId}' order by datetime desc";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
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
            string sqlQuery = @"INSERT INTO Products (Id, Name, Description, Price, ImageURL, CategoryID, BrandID, DateCreated, DatePurchase, Stock, ProviderId) 
                        VALUES (@Id, @Name, @Description, @Price, @ImageURL, @CategoryID, @BrandID, @DateCreated, @DatePurchase, @Stock, @ProviderId)";

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
            new SqlParameter("@Stock", product.Stock),
            new SqlParameter("@ProviderId", product.ProviderId)
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
                            Stock = @Stock,
                            ProviderId = @ProviderId
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
                new SqlParameter("@Stock", product.Stock),
                new SqlParameter("@ProviderId", product.ProviderId)
            };

            return myDbContext.ExecuteCommand(sqlQuery, CommandType.Text, parameters) > 0;
        }
        public DataTable GetProductByName(string name)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT * FROM Products WHERE name LIKE @name";
            var parameters = new IDataParameter[]
            {
                new SqlParameter("@name", $"%{name}%")
            };

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters);
        }
        public Product GetProductById(string Id)
        {
            MyDbContext myDbContext = new MyDbContext(Conn);
            Product pr = new Product();
            string sqlQuery = "SELECT * FROM Products WHERE id = @id";
            var parameters = new IDataParameter[]
            {
                new SqlParameter("@id", Id)
            };
            var res = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text, parameters); 
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                pr = new Product
                {
                    Id = row["Id"].ToString(),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    ImageURL = row["ImageURL"].ToString(),
                    CategoryID = row["CategoryID"].ToString(),
                    DateCreated = Convert.ToDateTime(row["DateCreated"]),
                    DatePurchase = Convert.ToDateTime(row["DatePurchase"]),
                    Stock = Convert.ToInt32(row["Stock"]),
                    BrandID = row["BrandID"].ToString(),
                    ProviderId = row["ProviderId"].ToString(),
                };
            }
            return pr;
        }
        public DataTable GetBrands()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT Id, Name FROM Brands";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }


        public DataTable GetCategories()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT Id, Name FROM Categories";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }

        public DataTable GetProvider()
        {
            MyDbContext myDbContext = new MyDbContext(Conn);

            string sqlQuery = "SELECT * FROM Provider";

            return myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
        }
    }
}
