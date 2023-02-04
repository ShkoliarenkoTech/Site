using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Data.Models;
using Site.Interfaces;

namespace Site.Data.Mocks
{
    public class MockCategories : IBakeryProductsCategory
    {
        public IEnumerable<Categories> allCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories {categoryName = "Cakes",description = "Freshly baked homemade cakes"},
                    new Categories {categoryName = "Bread", description = "First class hard flour bread"},
                    new Categories {categoryName ="Pancakes", description = "Non gluten fluffy pancakes" }
                };
            }
        }
    }
}
