using ShopMVP.Models;
using System.Collections.Generic;

namespace ShopMVP.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
        void RemoveProduct(Product product); 
    }
}
