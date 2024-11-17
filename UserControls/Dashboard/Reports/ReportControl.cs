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

namespace fazenda_verdeviva.UserControls.Dashboard.Reports
{
    public partial class ReportControl : UserControl
    {
        private static ReportControl? Instance;

        private ReportControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(ReportsListControl.GetInstance());
        }

        public static ReportControl GetInstance()
        {
            if( Instance == null)
            {
                Instance = new ReportControl();
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

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
