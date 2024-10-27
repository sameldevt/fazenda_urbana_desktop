using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    public partial class ProductCardControl : UserControl
    {
        private Product? Product;
        public ProductCardControl()
        {
            InitializeComponent();
        }
        public async Task LoadCardInfo(Product product)
        {
            this.Product = product;
            ProductName.Text = product.Name;
            ProductDescription.Text = product.Description;
            ProductPrice.Text = $"R$ {product.WeightPrice.ToString()} / kg";
            await Network.LoadWebpImageFromUrl(product.ImageUrl, ProductImage);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            ProductListControl.GetInstance().ProductsList.Controls.Remove(this);
            await ProductService.Delete(Product.Id);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editProductControlInstance = EditProductControl.GetInstance(); 
            editProductControlInstance.LoadProductInfo(Product);
            ProductsControl.GetInstance().SetContentPanelControl(editProductControlInstance);
        }
    }
}
