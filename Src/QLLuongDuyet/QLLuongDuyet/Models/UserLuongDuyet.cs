using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLuongDuyet.Models
{
    public class UserLuongDuyet
    {
        public string Id { get; set; }
        public string LuongDuyetId { get; set; }    
        public string UserId { set; get; }  
        public string OrderId { set; get; } 
    }
}
