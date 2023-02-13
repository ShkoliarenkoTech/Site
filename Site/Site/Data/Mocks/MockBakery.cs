using Site.Data.Models;
using Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Mocks
{
    public class MockBakery : IAllBakery
    {
        private readonly IBakeryProductsCategory _IBakeryProductsCategory = new MockCategories();

        public IEnumerable<bakeryProducts> _bakeryProducts
        {
            get
            {
                return new List<bakeryProducts>
                {
                    new bakeryProducts{
                        Name = "Whole wheat bread",
                        ShortDescription = "Wheat bread",
                        LongDescription = "Whole wheat bread first class hard flour bread" ,
                        Image = "/img/Whole wheat bread.jpg",
                        Price = 40,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(1) //maybe here is the problem that index start from 1. I need to check it carefully.
                     }, 
                      new bakeryProducts{
                        Name = "Sponge cake",
                        ShortDescription = "Cake",
                        LongDescription = "gluten free cake with hazelnuts and strawberry " ,
                        Image = "/img/Sponge cake.jpg",
                        Price = 80,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(0)
                     },
                      new bakeryProducts{
                        Name = "Hotcake",
                        ShortDescription = "Hotcake",
                        LongDescription = "Gluten free hotcake has been baked with little chopped strawberry inside that feels at your tongue" ,
                        Image = "/img/Hotcake.jpg",
                        Price = 20,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(2) 
                     },
                      new bakeryProducts{
                        Name = "Baguette",
                        ShortDescription = "Bread",
                        LongDescription = "Fragrant baguette directly from Paris bakery",
                        Image = "/img/Baguette.jpg",
                        Price = 30,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(1)
                     }
                };
            }
        }

        public IEnumerable<bakeryProducts> getFavouriteProducts {get; set;}


        public bakeryProducts getObjectBakery(int backeryID)
        {
            throw new NotImplementedException();
        }
    }
}
