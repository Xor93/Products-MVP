using ShopMVP.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopMVP.Services
{
    public class LocalProductService : IProductService 
    {
        private List<Product> products = new List<Product>() {
            new Product() { Id = 1, Title = "Apple", Price = 1.43 },
            new Product() { Id = 2, Title = "Orange", Price = 2.43 },
            new Product() { Id = 3, Title = "Mango", Price = 10.43 }
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
