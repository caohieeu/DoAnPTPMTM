using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Models
{
    public class ProductsUpdateDto
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public int Stock { set; get; }
        public decimal Price { set; get; }
    }
}
