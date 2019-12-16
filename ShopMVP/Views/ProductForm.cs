using ShopMVP.Models;
using System;
using System.Windows.Forms;

namespace ShopMVP.Views
{
    public partial class ProductForm : Form, IProductView
    {
        public event EventHandler<ProductEventArgs> AddedProductEvent;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product() {
                Title = titleTextBox.Text,
                Price = (double)priceNumericUpDown.Value
            };

            AddedProductEvent?.Invoke(this,
                new ProductEventArgs() {
                    Product = product
                });

            this.DialogResult = DialogResult.OK;
        }

        bool IView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK;
        }
    }
}
