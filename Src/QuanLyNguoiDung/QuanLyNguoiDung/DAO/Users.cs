using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoiDung.DAO
{
    public class Users
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        public DateTime? Birth { get; set; } = null;
        [Required]
        public string ImagePath { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        public string RoleId { get; set; }
        public Users()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 7);
        }
    }
}
