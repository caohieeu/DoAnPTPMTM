using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.Model
{
    public class Order
    {
        public string Id { get; set; }
        public string UserID { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime OrderDate { get; set; }

        public Order() { }

        public Order(string userID, string shippingAddress, string paymentMethod, string orderStatus, string deliveryStatus, DateTime orderDate)
        {
            UserID = userID;
            ShippingAddress = shippingAddress;
            PaymentMethod = paymentMethod;
            OrderStatus = orderStatus;
            DeliveryStatus = deliveryStatus;
            OrderDate = orderDate;
        }
    }

}
