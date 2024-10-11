using fazenda_verdeviva.UserControls.Dashboard.Clients;
using fazenda_verdeviva.UserControls.Dashboard.Products;
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
    public partial class ClientControl : UserControl
    {
        private static ClientControl? instance;
        private ClientControl()
        {
            InitializeComponent();
            ClientsList.AutoScroll = true;
            AddClientCards();
        }

        public static ClientControl GetInstance()
        {
            if(instance == null)
            {
                instance = new ClientControl();
            }
            return instance;
        }

        private void AddClientCards()
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
                ClientCardControl productCard = new ClientCardControl();

                // Adiciona o card ao FlowLayoutPanel
                ClientsList.Controls.Add(productCard);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
