﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Models
{
    public class Categories
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public List<bakeryProducts> bakeryProducts { get; set; }


    }
}
