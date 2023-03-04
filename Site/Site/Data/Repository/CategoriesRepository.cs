using Site.Data.Models;
using Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Repository
{
    public class CategoriesRepository : IBakeryProductsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoriesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Categories> allCategories => appDBContent.category;
    }
}
