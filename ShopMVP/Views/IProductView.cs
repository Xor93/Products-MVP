using ShopMVP.Models;
using System;

namespace ShopMVP.Views
{
    public interface IProductView : IView
    {
        event EventHandler<ProductEventArgs> AddedProductEvent;
    }

    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
}
