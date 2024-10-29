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

namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    public partial class SupplierControl : UserControl
    {
        private static SupplierControl? Instance;

        private SupplierControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(SupplierListControl.GetInstance());
        }

        public static SupplierControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplierControl();
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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            SetContentPanelControl(RegisterSupplierControl.GetInstance());
        }
    }
}
