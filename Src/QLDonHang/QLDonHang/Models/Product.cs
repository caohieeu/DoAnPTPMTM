using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLDonHang.Model
{
    public class Product
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; } = 0;
        [Required]
        public string ImageURL { get; set; } = string.Empty;
        [Required]
        public string CategoryID { get; set; } = string.Empty;
        [Required]
        public string BrandID { get; set; } = string.Empty;
        [Required]
        public DateTime? DateCreated { get; set; } = null;
        [Required]
        public DateTime? DatePurchase { get; set; } = null;
        [Required]
        public int Stock { get; set; } = 0;
        [Required]
        public string ProviderId { get; set; } = string.Empty;


        public Product()
        {
        }
        public Product(string id, string name, string description, decimal price, string imageURL, string categoryID, string brandID, DateTime dateCreated, DateTime datePurchase, int stock, string providerId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageURL = imageURL;
            CategoryID = categoryID;
            BrandID = brandID;
            DateCreated = dateCreated;
            DatePurchase = datePurchase;
            Stock = stock;
            ProviderId = providerId;
        }

    }
}
