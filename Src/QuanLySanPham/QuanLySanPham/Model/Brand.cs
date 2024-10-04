﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Model
{
    public class Brand
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Brand(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
