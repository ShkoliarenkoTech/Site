using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data
{
    public class DbObjects
    {
        public static void Initial(IApplicationBuilder app)
        {
            AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();
            if (!content.category.Any())
                content.category.AddRange(categories.Select(c => c.value));
        }

        private static Dictionary<string, Categories> Categ;
        public static Dictionary<string, Categories> Category
        {
            get
            {
                if (Categ == null)
                {
                    var list = new Categories[]
                    {
                    new Categories {categoryName = "Cakes",description = "Freshly baked homemade cakes"},
                    new Categories {categoryName = "Bread", description = "First class hard flour bread"},
                    new Categories {categoryName ="Pancakes", description = "Non gluten fluffy pancakes" }
                    };

                    Categ = new Dictionary<string, Categories>();
                    foreach (Categories el in list)
                        Categ.Add(el.categoryName, el);
                }

                return Category;
            }
        }
    }
}
