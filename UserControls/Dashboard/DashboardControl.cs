using fazenda_verdeviva.Forms;
using fazenda_verdeviva.UserControls.Dashboard;
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

            //ContentPanel = new Panel
            //{
            //    Dock = DockStyle.Fill
            //};

            Controls.Add(ContentPanel);

            SetContentPanelControl(new StockControl());
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
            //control.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(control);
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new StockControl());
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new OrdersControl());
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new ClientControl());
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new SupplierControl());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new ReportControl());
        }
    }
}
