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
            if(Instance == null)
            {
                Instance = new RegisterProductControl();
            }

            return Instance;
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // registrar produto
            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductsControl.GetInstance().RegisterButton.Enabled = true;
            ProductsControl.GetInstance().SetContentPanelControl(ProductListControl.GetInstance());
        }

        private void RegisterProductControl_Load(object sender, EventArgs e)
        {

        }
    }
}
