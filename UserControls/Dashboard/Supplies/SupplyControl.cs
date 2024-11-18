using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Supplies
{
    public partial class SupplyControl : UserControl
    {
        private static SupplyControl? Instance;

        private SupplyControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(SupplyListControl.GetInstance());
        }

        public static SupplyControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplyControl();
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            SetContentPanelControl(RegisterSupplyControl.GetInstance());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(SupplyListControl.GetInstance());
        }
    }

}
