using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_project.DataServices
{
    using Models;
    public class SimpleDataAccess
    {
        public List<Product> Products { get; set; }
        public void Load()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Sam Sung Galaxy 22"},
                 new Product { Id = 2, Name = "Iphone 11 promax"},
                 new Product { Id = 3, Name = "Iphone 12 pro"},
                 new Product { Id = 4, Name = "Iphone 13 Promax"},
                 new Product { Id = 5, Name = "Iphone X Promax"},
                 new Product { Id = 6, Name = "Nokia"},
            };
        }
        public void SaveChanges() { }
    }
}
