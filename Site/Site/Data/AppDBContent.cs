using Microsoft.EntityFrameworkCore;
using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }
        public DbSet<bakeryProducts> bakery { get; set; }
        public DbSet<Categories> category { get; set; }
    }
}
