using Microsoft.EntityFrameworkCore;
using Site.Data.Models;
using Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Repository
{

    public class BakeryRepository : IAllBakery
    {
        private readonly AppDBContent appDBContent;

        public BakeryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<bakeryProducts> _bakeryProducts => appDBContent.bakery.Include(c =>c.Categories);

        public IEnumerable<bakeryProducts> getFavouriteProducts => appDBContent.bakery.Where(p => p.IsFavourite).Include(c => c.Categories);

        public bakeryProducts getObjectBakery(int backeryID) => appDBContent.bakery.FirstOrDefault(p => p.Id == backeryID);
    }
}
