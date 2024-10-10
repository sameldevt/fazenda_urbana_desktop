using fazenda_verdeviva.UserControls.Dashboard;
using fazenda_verdeviva.UserControls.Dashboard.Stock;
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
    public partial class StockControl : UserControl
    {
        private static StockControl instance;

        public StockControl()
        {
            InitializeComponent();

            Controls.Add(ContentPanel);

            SetContentPanelControl(new ProductsControl());
        }

        public static StockControl GetInstance()
        {
            if (instance == null)
            {
                instance = new StockControl();
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

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(new CategoryControl());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
