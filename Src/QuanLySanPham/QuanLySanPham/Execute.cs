using Microsoft.VisualBasic.ApplicationServices;
using QuanLySanPham.DAO;
using QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class Execute
    {
        private readonly ProductDao _productDao;
        public Execute(ProductDao productDao)
        {
            _productDao = productDao;
        }
        public List<string> ValidateUser(Product product)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(product);

            bool isValid = Validator.TryValidateObject(product, validationContext, validationResults);

            List<string> errors = new List<string>();
            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    errors.Add(validationResult.ErrorMessage);
                }
            }

            return errors;
        }
        private bool ShowError(Product product)
{
            var errors = ValidateUser(product);

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors),
                    "Validate Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool Add(Product product)
        {
            if (ShowError(product))
            {
                return _productDao.InsertProduct(product);
            }

            return false;
        }
        public Product getPrById(string id)
        {
            return _productDao.GetProductById(id);
        }
        public DataTable getBrand()
        {
            return _productDao.GetBrands();
        }
        public DataTable getCategories()
        {
            return _productDao.GetCategories();
        }
        public bool UpdateProduct(Product product)
        {
            return _productDao.UpdateProduct(product);
        }
        public bool DeleteProduct(string productId)
        {
            return _productDao.DeleteProduct(productId);
        }
    }
}
