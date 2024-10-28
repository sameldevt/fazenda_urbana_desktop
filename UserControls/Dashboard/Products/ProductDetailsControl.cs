using fazenda_verdeviva.Model.Entities;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    public partial class ProductDetailsControl : UserControl
    {
        public static ProductDetailsControl? Instance;
        public ProductDetailsControl()
        {
            InitializeComponent();
        }

        public static ProductDetailsControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ProductDetailsControl();
            }
            return Instance;
        }

        public void LoadProductInfo(Product product)
        {
            ProductName.Text = product.Name;
            ProductDescription.Text = product.Description;
            ProductQuantity.Text = $"{product.StockQuantity.ToString()} kg";
            ProductPrice.Text = $"R$ {product.WeightPrice.ToString()}";
            ProductCategory.Text = product.Category.Name;
            ProductCalories.Text = $"{product.NutritionalInfo.Calories.ToString()} g";
            ProductCarbs.Text = $"{product.NutritionalInfo.Carbohydrates.ToString()} g";
            ProductProteins.Text = $"{product.NutritionalInfo.Proteins.ToString()} g";
            ProductFibers.Text = $"{product.NutritionalInfo.Fibers.ToString()} g";
            ProductFats.Text = $"{product.NutritionalInfo.Fats.ToString()} g"; 
            SupplierName.Text = product.Supplier.Name;
            SupplierEmail.Text = product.Supplier.Contact?.Email ?? "E-mail não cadastrado";
            SupplierCnpj.Text = product.Supplier.CNPJ ?? "CPNJ não cadastrado";
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }
    }
}
