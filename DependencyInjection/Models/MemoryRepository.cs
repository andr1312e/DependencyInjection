using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository:IRepostitory
    {
        private Dictionary<string, Product> products;
        public MemoryRepository()
        {
            products = new Dictionary<string, Product>();
            new List<Product>
            {
                new Product{Name="Kayak", Price=25M },
                new Product{Name="LifeJacket", Price=155M },
                new Product{Name="Soccer ball", Price=15.50M }
            }.ForEach(p => addProduct(p));
        }

        public IEnumerable<Product> Products => products.Values;

        public Product this[string name] => throw new NotImplementedException();

        public void addProduct(Product product)
        {
            this.products[product.Name] = product;
        }

        public void deleteProduct(Product product)
        {
            products.Remove(product.Name);
        }
    }
}
