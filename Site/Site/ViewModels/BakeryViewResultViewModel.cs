﻿using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.ViewModels
{
    public class BakeryViewResultViewModel
    {
        public IEnumerable<bakeryProducts> AllBakery { get; set; }

        public string BakeryCategory { get; set; }


    }
}
