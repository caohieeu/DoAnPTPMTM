﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace ProjectShoeShop.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "The product name field is required")]
        [MinLength(6, ErrorMessage = "Product name should contain at least 6 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description field is required")]
        [MinLength(6, ErrorMessage = "Description should contain at least 10 characters")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Size field is required")] 
        //public string Size { get; set; }
        [Required(ErrorMessage = "Price field is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price should be greater than or equal to 0")]
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DatePurchase { get; set; }
        [Required(ErrorMessage = "Gender field is required")]
        //public string GenderShoe { get; set; }
        public int Stock { get; set; }
        [Required(ErrorMessage = "File img is required")]
        public string ImageURL { get; set; }
        public string CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }
        public string BrandID { get; set; }
        [ForeignKey(nameof(BrandID))]
        public Brand Brand { get; set;}
        public string ProviderId { get; set; }
        [ForeignKey(nameof(ProviderId))]
        public Provider Provider { get; set; }
    }
}