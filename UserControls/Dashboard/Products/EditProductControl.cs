using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using SkiaSharp;
using System;
using System.CodeDom;
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
    public partial class EditProductControl : UserControl
    {
        private static EditProductControl? Instance;
        private Product Product;

        private EditProductControl()
        {
            InitializeComponent();
        }

        public static EditProductControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditProductControl();
            }

            Instance.LoadCategories();
            Instance.ClearProductInfos();
            return Instance;
        }

        private async Task LoadCategories()
        {
            var categories = await ProductService.GetInstance().GetCategoriesAsync();

            if (categories != null && categories.Any())
            {
                CategoryComboBox.DataSource = null;

                CategoryComboBox.DisplayMember = "Name";
                CategoryComboBox.ValueMember = "Id";
                CategoryComboBox.DataSource = categories;

                CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void ClearProductInfos()
        {
            ProductNameTextBox.Text = string.Empty;
            ProductDescriptionTextBox.Text = string.Empty;
            ProductPriceTextBox.Text = string.Empty;
            ProductQuantityTextBox.Text = string.Empty;
            ProductImageUrlTextBox.Text = string.Empty;
            ProductCaloriesTextBox.Text = string.Empty;
            ProductCarbsTextBox.Text = string.Empty;
            ProductProteinsTextBox.Text = string.Empty;
            ProductFibersTextBox.Text = string.Empty;
            ProductFatsTextBox.Text = string.Empty;

            ProductImage.Image = null;
        }
        public async void LoadProductInfo(Product product)
        {
            Product = product;
            ProductNameTextBox.Text = product.Name;
            ProductDescriptionTextBox.Text = product.Description;
            ProductImageUrlTextBox.Text = product.ImageUrl;
            ProductPriceTextBox.Text = $"R$ {product.WeightPrice.ToString()} / kg";
            ProductQuantityTextBox.Text = product.WeightPrice.ToString();
            ProductCaloriesTextBox.Text = product.NutritionalInfo.Calories.ToString();
            ProductCarbsTextBox.Text = product.NutritionalInfo.Carbohydrates.ToString();
            ProductFatsTextBox.Text = product.NutritionalInfo.Fats.ToString();
            ProductFibersTextBox.Text = product.NutritionalInfo.Fibers.ToString();
            ProductProteinsTextBox.Text = product.NutritionalInfo.Proteins.ToString();
            await LoadProductImage(product);
        }

        private async Task LoadProductImage(Product product)
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


        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (ProductPriceTextBox.Text.Contains(".") || ProductPriceTextBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void ProductQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductCaloriesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductProteinsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductCarbsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductFibersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductFatsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var updateProductDto = new UpdateProductDto
            {
                Id = Product.Id,
                Name = ProductNameTextBox.Text,
                Description = ProductDescriptionTextBox.Text,
                WeightPrice = decimal.Parse(ProductPriceTextBox.Text
                .Replace("R$ ", "")
                .Replace(" / kg", "")),
                StockQuantity = int.Parse(ProductQuantityTextBox.Text),
                NutritionalInfo = new NutritionalInfoDto
                {
                    Calories = decimal.Parse(ProductCaloriesTextBox.Text),
                    Proteins = decimal.Parse(ProductProteinsTextBox.Text),
                    Carbohydrates = decimal.Parse(ProductCarbsTextBox.Text),
                    Fibers = decimal.Parse(ProductFibersTextBox.Text),
                    Fats = decimal.Parse(ProductFatsTextBox.Text)
                },
                CategoryId = (int)CategoryComboBox.SelectedValue,
            };

            var response = await ProductService.GetInstance().Update(updateProductDto);

            MessageBox.Show(response);
            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private void LoadProductImage(object sender, EventArgs e)
        {
            LoadProductImage();
        }

        private async Task LoadProductImage()
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(ProductImageUrlTextBox.Text);

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
    }
}
