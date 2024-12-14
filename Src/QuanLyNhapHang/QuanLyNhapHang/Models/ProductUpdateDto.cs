using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Models
{
    public class ProductUpdateDto
    {
        public string Id { get; set; }
        public string GoodsReceiptId { set; get; }
        public string ProductId { get; set; }  
    }
}
