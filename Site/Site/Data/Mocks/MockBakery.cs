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

        public IEnumerable<bakeryProducts> bakeryProducts
        {
            get
            {
                return new List<bakeryProducts>
                {
                    new bakeryProducts{
                        Name = "Whole wheat bread",
                        ShortDescription = "Wheat bread",
                        LongDescription = "Whole wheat bread first class hard flour bread" ,
                        Image = "https://thewoksoflife.com/wp-content/uploads/2016/12/whole-wheat-bread-5.jpg",
                        Price = 40,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(1) //maybe here is the problem that index start from 1. I need to check it carefully.
                     }, 
                      new bakeryProducts{
                        Name = "Sponge cake",
                        ShortDescription = "Cake",
                        LongDescription = "gluten free cake with hazelnuts and strawberry " ,
                        Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001468_10-81b47f5.jpg",
                        Price = 80,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(0)
                     },
                      new bakeryProducts{
                        Name = "Hotcake",
                        ShortDescription = "Pancake",
                        LongDescription = "Gluten free pancake has been baked with little chopped strawberry inside that feels at your tongue" ,
                        Image = "https://img.taste.com.au/HG7nEkge/taste/2016/11/american-hotcakes-98829-1.jpeg",
                        Price = 20,
                        IsFavourite = true,
                        Avaliable = true,
                        Categories = _IBakeryProductsCategory.allCategories.ElementAt(2) 
                     },
                      new bakeryProducts{
                        Name = "Baguette",
                        ShortDescription = "Bread",
                        LongDescription = "Fragrant baguette directly from Paris bakery",
                        Image = "https://cuk-it.com/wp-content/uploads/2020/07/thumb03-low-1-1024x576.jpg",
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
