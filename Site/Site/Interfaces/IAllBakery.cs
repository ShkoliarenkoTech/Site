﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Data.Models;

namespace Site.Interfaces
{
    interface IAllBakery
    {
        IEnumerable<bakeryProducts> bakeryProducts { get; set; }
        IEnumerable<bakeryProducts> getFavouriteProducts { get; set; }
        bakeryProducts getObjectBakery(int backeryID);
    }
}