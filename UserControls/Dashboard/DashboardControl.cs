using fazenda_verdeviva.Forms;
using fazenda_verdeviva.UserControls.Dashboard;
using fazenda_verdeviva.UserControls.Dashboard.Products;
using fazenda_verdeviva.UserControls.Dashboard.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private static DashboardControl instance;

        private DashboardControl()
        {
            InitializeComponent();

            Controls.Add(ContentPanel);

            SetContentPanelControl(new ProductsControl());
        }

        public static DashboardControl GetInstance()
        {
            if (instance == null)
            {
                instance = new DashboardControl();
            }
            return instance;
        }


        public void SetContentPanelControl(UserControl control)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(control);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new ProductsControl());
        }

        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new ManufacturerControl());
        }

        private void OrdersButton_Click_1(object sender, EventArgs e)
        {
            SetContentPanelControl(new OrdersControl());

        }

        private void ClientsButton_Click_1(object sender, EventArgs e)
        {
            SetContentPanelControl(new ClientControl());
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
