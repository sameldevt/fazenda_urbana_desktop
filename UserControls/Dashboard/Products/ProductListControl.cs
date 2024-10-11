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
    public partial class ProductListControl : UserControl
    {
        private static ProductListControl? Instance;
        private ProductListControl()
        {
            InitializeComponent();
            ProductsList.AutoScroll = true;
            AddProductCards();
        }

        public static ProductListControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ProductListControl();
            }
            return Instance;
        }

        private void AddProductCards()
        {
            // Simulando alguns produtos
            string[,] products = new string[,]
            {
            { "Laptop", "$1000" },
            { "Smartphone", "$700" },
            { "Tablet", "$300" },
            { "Tablet", "$300" },
            { "Tablet", "$300" },
            { "Tablet", "$300" },
            { "Tablet", "$300" },
            };

            // Loop para criar e adicionar um card de produto para cada produto
            for (int i = 0; i < products.GetLength(0); i++)
            {
                // Cria um novo card de produto usando o UserControl
                ProductCardControl productCard = new ProductCardControl();

                // Adiciona o card ao FlowLayoutPanel
                ProductsList.Controls.Add(productCard);
            }
        }


        private void ProductsList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
