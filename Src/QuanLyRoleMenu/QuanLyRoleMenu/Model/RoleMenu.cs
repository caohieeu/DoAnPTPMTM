using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRoleMenu.Model
{
    public class RoleMenu
    {
        public RoleMenu()
        {
        }

        public RoleMenu(string roleId, string menuId)
        {
            RoleId = roleId;
            MenuId = menuId;
        }

        public string RoleId { get; set; }
        public string MenuId { get; set; }
    }

}
