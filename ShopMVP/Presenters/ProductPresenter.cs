using ShopMVP.Models;
using ShopMVP.Services;
using ShopMVP.Views;

namespace ShopMVP.Presenters
{
    public class ProductPresenter
    {
        private IProductView productView;
        private IProductService writer;

        public IView View { get { return productView; } }

        public Product Product { get; set; }

        public ProductPresenter(IProductView productView, IProductService writer)
        {
            this.productView = productView;
            this.writer = writer;
            EventSubscription();
        }

        private void EventSubscription()
        {
            productView.AddedProductEvent += ProductView_AddedProductEvent;
        }

        private void ProductView_AddedProductEvent(object sender, ProductEventArgs e)
        {
            Product = e.Product;
            writer.AddProduct(Product);
        }
    }
}
