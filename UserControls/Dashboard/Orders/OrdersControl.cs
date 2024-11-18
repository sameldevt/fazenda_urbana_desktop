using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
using fazenda_verdeviva.UserControls.Dashboard.Messages;
using fazenda_verdeviva.UserControls.Dashboard.Orders;
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
    public partial class OrdersControl : UserControl
    {
        private static OrdersControl? Instance;
        private OrdersControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(OrderListControl.GetInstance());
        }

        public static OrdersControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new OrdersControl();
            }

            return Instance;
        }

        public void SetContentPanelControl(UserControl control)
        {
            ContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(control);
            ContentPanel.PerformLayout();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(OrderListControl.GetInstance());
        }
    }
}
