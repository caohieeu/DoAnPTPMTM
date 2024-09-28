using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Model
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string CategoryID { get; set; }
        public string BrandID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DatePurchase { get; set; }
        public int Stock { get; set; }
    }
}
