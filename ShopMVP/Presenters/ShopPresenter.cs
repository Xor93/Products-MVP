using ShopMVP.Models;
using ShopMVP.Services;
using ShopMVP.Views;
using System;
using System.Collections.Generic;

namespace ShopMVP.Presenters
{
    public class ShopPresenter
    {
        private IShopView shopView;
        private IProductService writer;

        public IView View { get { return shopView; } }

        public ShopPresenter(IShopView shopView, IProductService writer)
        {
            this.shopView = shopView;
            this.writer = writer;
            EventSubscription();
        }

        private void EventSubscription()
        {
            shopView.LoadProductsEvent += ShopView_LoadProductsEvent;
            shopView.AddProductEvent += ShopView_AddProductEvent;
            shopView.RemoveProductEvent += ShopView_RemoveProductEvent;
        }

        private void ShopView_RemoveProductEvent(object sender, ProductEventArgs e)
        {
            writer.RemoveProduct(e.Product);
            shopView.RemoveProduct(e.Product);
        }

        private void ShopView_LoadProductsEvent(object sender, EventArgs e)
        {
            List<Product> products = writer.GetProducts();
            shopView.SetProducts(products);
        }

        private void ShopView_AddProductEvent(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = IOC.Resolve<ProductPresenter>();
            if (productPresenter.View.ShowDialog())
            {
                shopView.AddProduct(productPresenter.Product);
            }
        }
    }
}
