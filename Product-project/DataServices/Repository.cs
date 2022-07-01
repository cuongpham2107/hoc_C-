using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_project.DataServices
{
    using Models;
    public class Repository
    {
        protected readonly SimpleDataAccess _context;
        public Repository(SimpleDataAccess context)
        {
            _context = context;
            _context.Load();
        }
        public void SaveChanges() => _context.SaveChanges();
        public List<Product> Products => _context.Products;
        public Product[] Select() => _context.Products.ToArray();
        public Product Select(int id)
        {
            foreach(var product in _context.Products){
                if(product.Id == id)
                    return product;
            }
            return null;
        }
        public Product[] Select(string key)
        {
            var temp = new List<Product>();
            var k = key.ToLower();
            foreach(var product in _context.Products)
            {
                var logic =
                    product.Name.ToLower().Contains(k) ||
                    product.Image.ToLower().Contains(k);
                if(logic) 
                    temp.Add(product);
            }
            return temp.ToArray();
        }
        public void Insert(Product product)
        {
            var lastIndex = _context.Products.Count - 1;
            var id = lastIndex < 0 ? 1 : _context.Products[lastIndex].Id + 1;
            product.Id = id;
            _context.Products.Add(product);
        }
        public bool Delete(int id)
        {
            var b = Select(id);
            if (b == null)
                return false;
            _context.Products.Remove(b);
            return true;
        }
        public bool Update(int id, Product product)
        {
            var p = Select(id);
            if (p == null)
                return false;
            p.Name = product.Name;
            p.Image = product.Image;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            p.Created_at = product.Created_at;
            return true;
        }
    }
}
