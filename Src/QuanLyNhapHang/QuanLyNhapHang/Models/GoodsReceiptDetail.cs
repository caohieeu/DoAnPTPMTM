using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Models
{
    public class GoodsReceiptDetail
    {
        public string Id { get; set; }
        public string GoodsReceiptId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Ship { get; set; }
        public int Status { get; set; }
    }
}
