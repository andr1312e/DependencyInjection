using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public interface IRepostitory
    {
        IEnumerable<Product> Products { get; }
        Product this[string name] { get; }
        void addProduct(Product product);
        void deleteProduct(Product product);
    }
}
