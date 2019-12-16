using ShopMVP.Models;
using System;
using System.Collections.Generic;

namespace ShopMVP.Views
{
    public interface IShopView : IView
    {
        event EventHandler<EventArgs> LoadProductsEvent;
        void SetProducts(List<Product> products);
        event EventHandler<EventArgs> AddProductEvent;
        void AddProduct(Product product);
        event EventHandler<ProductEventArgs> RemoveProductEvent;
        void RemoveProduct(Product product);
    }
}
