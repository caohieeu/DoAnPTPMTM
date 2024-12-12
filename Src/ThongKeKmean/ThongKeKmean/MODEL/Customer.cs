using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongKeKmean.MODEL
{
    public class Customer
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Age { get; set; }
        public double TotalPurchaseAmount { get; set; }
        public int Cluster { get; set; } 
    }
}
