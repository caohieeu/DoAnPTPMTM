using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShoeShop.Models
{
    public class Provider
    {
        [Key]
        public string Id { set; get; }
        public string Name { set;get; }
        public string Address { set; get; }
        public string Phone { set; get; }
    }
}
