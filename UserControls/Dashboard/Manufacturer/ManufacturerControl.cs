using fazenda_verdeviva.UserControls.Dashboard.Clients;
using fazenda_verdeviva.UserControls.Dashboard.Manufacturer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard
{
    public partial class ManufacturerControl : UserControl
    {
        private static ManufacturerControl? Instance;
        private ManufacturerControl()
        {
            InitializeComponent();
            ManufacturersList.AutoScroll = true;    
            AddManufacturerCards();
        }

        public static ManufacturerControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ManufacturerControl();
            }
            return Instance;
        }

        private void AddManufacturerCards()
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
                ManufacturerCardControl productCard = new ManufacturerCardControl();

                // Adiciona o card ao FlowLayoutPanel
                ManufacturersList.Controls.Add(productCard);
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
