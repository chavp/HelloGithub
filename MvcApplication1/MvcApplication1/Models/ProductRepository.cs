using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ProductRepository
    {
        List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>(new Product[]{
                new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
            });

            _products.TakeWhile(p => p.Name == "Kayak");
        }

        public IEnumerable<Product> All()
        {
            foreach (var p in _products)
            {
                yield return p;
            }
        }
    }
}