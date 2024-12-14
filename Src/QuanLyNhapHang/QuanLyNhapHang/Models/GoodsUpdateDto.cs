using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Models
{
    public class GoodsUpdateDto
    {
        public string Id { get; set; }
        public string GoodsReceiptId { set; get; }
        public string ProductId { get; set; }  
        public int Quantity { get; set; }
    }
}
