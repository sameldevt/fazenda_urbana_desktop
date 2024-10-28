﻿using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            return Instance;
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
                CategoryId = CategoryComboBox.SelectedIndex,
                SupplierId = SupplierComboBox.SelectedIndex,
            };

            await ProductService.Register(product);
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