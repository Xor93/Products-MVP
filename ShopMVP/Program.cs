using ShopMVP.Models;
using ShopMVP.Presenters;
using ShopMVP.Services;
using ShopMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region IOC setting
            IOC.Register<ShopForm, IShopView>();
            IOC.Register<ProductForm, IProductView>();
            IOC.Register<XmlProductService, IProductService>();
            IOC.Register<ShopPresenter>();
            IOC.Register<ProductPresenter>();
            IOC.Build();
            #endregion

            ShopPresenter shopPresenter = IOC.Resolve<ShopPresenter>();

            Application.Run((Form)shopPresenter.View);
        }
    }
}
