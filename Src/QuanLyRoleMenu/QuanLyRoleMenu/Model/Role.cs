using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRoleMenu.Model
{
    public class Role
    {
        public Role(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Role()
        {
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }

}
