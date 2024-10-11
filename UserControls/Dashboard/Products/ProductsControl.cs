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
    public partial class ProductsControl : UserControl
    {
        private static ProductsControl? Instance;

        private ProductsControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(ProductListControl.GetInstance());
        }

        public static ProductsControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ProductsControl();
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

        private void ProductsList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            SetContentPanelControl(RegisterProductControl.GetInstance());
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
