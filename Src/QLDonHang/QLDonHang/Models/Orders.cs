namespace QLDonHang.Models
{
    public class Orders
    {
        public string Id { get; set; }
        public string UserID { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
