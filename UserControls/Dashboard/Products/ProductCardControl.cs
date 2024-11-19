using fazenda_verdeviva.Model.Common;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using SkiaSharp;
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

        public void LoadCardInfo(Product product)
        {
            this.Product = product;
            ProductName.Text = product.Name;
            ProductDescription.Text = product.Description;
            ProductQuantity.Text = $"{product.StockQuantity.ToString("F2")} kg";
            ProductPrice.Text = $"R$ {product.WeightPrice.ToString("F2")}";
            LoadProductImage(product);
        }

        private async void LoadProductImage(Product product)
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(product.ImageUrl);

                try
                {
                    using MemoryStream ms = new MemoryStream(imageData);
                    ProductImage.Image = Image.FromStream(ms);
                }
                catch (ArgumentException)
                {
                    using SKBitmap bitmap = SKBitmap.Decode(imageData);

                    using SKImage image = SKImage.FromBitmap(bitmap);
                    using SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100);

                    using MemoryStream ms = new MemoryStream(data.ToArray());
                    ProductImage.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                ProductImage.Image = Image.FromFile("Assets/image-not-found.png");
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var response = await ProductService.GetInstance().Delete(Product!.Id);
            
            ProductListControl.GetInstance().ProductsList.Controls.Remove(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editProductControlInstance = EditProductControl.GetInstance();
            editProductControlInstance.LoadProductInfo(Product);
            ProductsControl.GetInstance().SetContentPanelControl(editProductControlInstance);
        }

        private void ProductDetails_Click(object sender, EventArgs e)
        {
            var productDetailsControlInstance = ProductDetailsControl.GetInstance();
            productDetailsControlInstance.LoadProductInfo(Product);
            ProductsControl.GetInstance().SetContentPanelControl(productDetailsControlInstance);
        }
    }
}
