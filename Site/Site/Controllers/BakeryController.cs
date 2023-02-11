﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Interfaces;

namespace Site.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IAllBakery _allBakery;
        private readonly IBakeryProductsCategory _allCategories;

        public BakeryController(IAllBakery iallBakery ,
            IBakeryProductsCategory iallBakeryProductsCategory) {

            _allBakery = iallBakery;
            _allCategories = iallBakeryProductsCategory;
        }

        public ViewResult ViewResult()
        {

            var bakery = _allBakery.bakeryProducts; 
            return View(bakery);
        }

    }
}