using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
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

            return Instance;
        }

        public void LoadProductInfo(Product product)
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
        }

        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número, controle, ponto ou vírgula
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;  // Cancela a entrada se não for permitido
            }

            // Permite apenas um ponto ou vírgula no TextBox
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (ProductPriceTextBox.Text.Contains(".") || ProductPriceTextBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void ProductQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private void ProductCaloriesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private void ProductProteinsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private void ProductCarbsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private void ProductFibersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private void ProductFatsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número e nem um controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Cancela a entrada se não for número
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await ProductService.Update(Product);

            var productList = ProductListControl.GetInstance();
            productList.ProductsList.Controls.Clear();
            productList.LoadProductCards();

            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }
    }
}
