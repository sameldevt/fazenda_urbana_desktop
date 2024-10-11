using fazenda_verdeviva.UserControls.Dashboard.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Employee
{
    public partial class EmployeeControl : UserControl
    {
        private static EmployeeControl? Instance;
        private EmployeeControl()
        {
            InitializeComponent();
            EmployeeList.AutoScroll = true;
            AddEmployeeCards();
        }

        public static EmployeeControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EmployeeControl();
            }

            return Instance;
        }

        private void AddEmployeeCards()
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
                EmployeeCardControl productCard = new EmployeeCardControl();

                // Adiciona o card ao FlowLayoutPanel
                EmployeeList.Controls.Add(productCard);
            }
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
