using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Models
{
    public class bakeryProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string  LongDescription { get; set; }
        public string Image { get; set; }
        public uint Price { get; set; }
        public int Avaliable { get; set; }
        public bool IsFavourite { get; set; }
        public int CategoryID { get; set; }
        public Categories Categories { get; set; }

    }
}
