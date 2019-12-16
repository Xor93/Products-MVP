using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ShopMVP.Models;

namespace ShopMVP.Views
{
    public partial class ShopForm : Form, IShopView
    {
        private BindingList<Product> products = new BindingList<Product>();

        public event EventHandler<EventArgs> LoadProductsEvent;
        public event EventHandler<EventArgs> AddProductEvent;
        public event EventHandler<ProductEventArgs> RemoveProductEvent;

        public ShopForm()
        {
            InitializeComponent();

            shopListBox.DataSource = products;
            shopListBox.DisplayMember = "Title";
        }

        public void SetProducts(List<Product> products)
        {
            this.products.Clear();
            foreach(Product p in products)
            {
                this.products.Add(p);
            }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            LoadProductsEvent?.Invoke(this, new EventArgs());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProductEvent?.Invoke(this, new EventArgs());
        }

        bool IView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shopListBox.SelectedIndex != -1)
            {
                RemoveProductEvent?.Invoke(this, new ProductEventArgs()
                    { Product = shopListBox.SelectedItem as Product }
                );
            }
        }

        private void shopListBox_MouseDown(object sender, MouseEventArgs e)
        {
            shopListBox.SelectedIndex = shopListBox.IndexFromPoint(e.X, e.Y);
            removeToolStripMenuItem.Enabled = shopListBox.SelectedIndex != -1;
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
