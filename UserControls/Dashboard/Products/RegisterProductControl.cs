using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Suppliers;
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
    public partial class RegisterProductControl : UserControl
    {
        private static RegisterProductControl? Instance;

        private RegisterProductControl()
        {
            InitializeComponent();
        }

        public static RegisterProductControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterProductControl();
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

        private async void RegisterButton_Click(object sender, EventArgs e)
        {

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

        private async void RegisterButton_Click_1(object sender, EventArgs e)
        {
            var product = new RegisterProductDto
            {
                Name = ProductNameTextBox.Text,
                Description = ProductDescriptionTextBox.Text,
                WeightPrice = decimal.Parse(ProductPriceTextBox.Text),
                StockQuantity = int.Parse(ProductQuantityTextBox.Text),
                ImageUrl = ProductImageUrlTextBox.Text,
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

            var response = await ProductService.GetInstance().Register(product);

            MessageBox.Show("Produto cadastrado com sucesso");

            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private async Task ShowRegisterCategoryForm()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 260,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Cadastrar categoria",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label categoryNameLabel = new Label() { Left = 20, Top = 20, Text = "Nome" };
            TextBox categoryNameTextBox = new TextBox() { Left = 20, Top = 50, Width = 340 };

            Label categoryDescriptionLabel = new Label() { Left = 20, Top = 90, Text = "Descrição" };
            TextBox categoryDescriptionTextBox = new TextBox() { Left = 20, Top = 120, Width = 340 };

            Button confirmation = new Button() { Text = "Cadastrar", Left = 260, Width = 100, Top = 160, Height = 30, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(categoryNameLabel);
            prompt.Controls.Add(categoryNameTextBox);
            prompt.Controls.Add(categoryDescriptionLabel);
            prompt.Controls.Add(categoryDescriptionTextBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                var category = new RegisterCategoryDto
                {
                    Name = categoryNameTextBox.Text,
                    Description = categoryDescriptionTextBox.Text
                };

                var productService = ProductService.GetInstance();
                await productService.RegisterCategory(category);
            }
        }

        private async void RegisterCategoryButton_Click(object sender, EventArgs e)
        {
            await ShowRegisterCategoryForm();
            await LoadCategories();
        }

        private void RegisterSupplierButton_Click(object sender, EventArgs e)
        {
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
            var supplierControl = SupplierControl.GetInstance();
            supplierControl.SetContentPanelControl(RegisterSupplierControl.GetInstance());
            DashboardControl.GetInstance().SetContentPanelControl(supplierControl); ;
        }
    }
}
