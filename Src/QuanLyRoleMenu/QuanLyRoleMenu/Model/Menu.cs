using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRoleMenu.Model
{
    public class Menu
    {
        public Menu()
        {
        }

        public Menu(string menuId, string assemblyName, string nameSpace, string menuName)
        {
            MenuId = menuId;
            AssemblyName = assemblyName;
            NameSpace = nameSpace;
            MenuName = menuName;
        }

        public string MenuId { get; set; }
        public string AssemblyName { get; set; }
        public string NameSpace { get; set; }
        public string MenuName { get; set; }


    }

}
