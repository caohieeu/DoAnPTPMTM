using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;
using QuanLyHoaDon.DAO;
using QuanLyHoaDon.Model;

namespace QuanLyHoaDon
{
    public class ExecuteOrder
    {
        private readonly OrderDao _orderDao;
        private readonly OrderDetailDao _orderDetailDao;

        public ExecuteOrder(OrderDao orderDao, OrderDetailDao orderDetailDao)
        {
            _orderDao = orderDao;
            _orderDetailDao = orderDetailDao;
        }

        // Validate Order thông qua các Annotation trong model
        public List<string> ValidateOrder(Order order)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(order);

            bool isValid = Validator.TryValidateObject(order, validationContext, validationResults, true);

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

        // Hiển thị lỗi nếu validation thất bại
        private bool ShowError(Order order)
        {
            var errors = ValidateOrder(order);

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors),
                    "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Thêm Order mới
        public bool AddOrder(Order order)
        {
            if (ShowError(order))
            {
                return _orderDao.InsertOrder(order);
            }

            return false;
        }

        // Lấy Order theo Id
        public Order GetOrderById(string id)
        {
            return _orderDao.GetOrderById(id);
        }
        public DataTable GetOrderDetails(string id)
        {
            return _orderDetailDao.GetOrderDetailsByOrderId(id);
        }
        // Lấy danh sách Order
        public DataTable GetOrders()
        {
            return _orderDao.GetOrders();
        }

        // Cập nhật Order
        public bool UpdateOrder(Order order)
        {
            if (ShowError(order))
            {
                return _orderDao.UpdateOrder(order);
            }

            return false;
        }

        // Xóa Order theo Id
        public bool DeleteOrder(string orderId)
        {
            return _orderDao.DeleteOrder(orderId);
        }

        public decimal GetTotalPriceByOrderId(string id)
        {
            return _orderDetailDao.GetTotalPriceByOrderId(id);
        }
    }
}
