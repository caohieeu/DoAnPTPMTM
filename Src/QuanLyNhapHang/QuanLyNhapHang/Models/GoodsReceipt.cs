using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Models
{
    public class GoodsReceipt
    {
        public string Id { get; set; }
        public string ProviderId { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal TotalShip { get; set; } = 0;
        public decimal TotalProduct { get; set; } = 0;
        public decimal TotalPrice { get; set; } = 0;
        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
    }
}
