using fazenda_verdeviva.UserControls.Dashboard.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    public partial class ContactMessageControl : UserControl
    {
        private static ContactMessageControl? Instance;
        private ContactMessageControl()
        {
            InitializeComponent();
            MessagesList.AutoScroll = true;
            AddMessagesCards();
        }

        public static ContactMessageControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ContactMessageControl();
            }

            return Instance;
        }

        private void AddMessagesCards()
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
                ContactMessageCardControl productCard = new ContactMessageCardControl();

                // Adiciona o card ao FlowLayoutPanel
                MessagesList.Controls.Add(productCard);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
