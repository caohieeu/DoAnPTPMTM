﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Enviroment
    {
        public static string UserName { get; set; } = string.Empty;
        public static string UserImage { set; get; } = string.Empty;
        public static string UserRole { set; get; } = string.Empty;
    }
}
