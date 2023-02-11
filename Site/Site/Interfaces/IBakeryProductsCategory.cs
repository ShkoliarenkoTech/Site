using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Data.Models;



namespace Site.Interfaces
{
    public interface IBakeryProductsCategory
    {
        IEnumerable<Categories> allCategories { get; }
    }
}
