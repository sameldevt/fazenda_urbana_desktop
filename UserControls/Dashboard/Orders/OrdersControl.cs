using fazenda_verdeviva.UserControls.Dashboard.Messages;
using fazenda_verdeviva.UserControls.Dashboard.Orders;
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
    public partial class OrdersControl : UserControl
    {
        private static OrdersControl? Instance;
        private OrdersControl()
        {
            InitializeComponent();
            OrdersList.AutoScroll = true;
            AddOrdersCards();
        }

        public static OrdersControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new OrdersControl();
            }

            return Instance;
        }

        private void AddOrdersCards()
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
                OrderCardControl productCard = new OrderCardControl();

                // Adiciona o card ao FlowLayoutPanel
                OrdersList.Controls.Add(productCard);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
