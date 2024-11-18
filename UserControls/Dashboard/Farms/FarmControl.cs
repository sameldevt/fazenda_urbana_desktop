using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    public partial class FarmControl : UserControl
    {
        private static FarmControl? Instance;

        private FarmControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(FarmListControl.GetInstance());
        }

        public static FarmControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new FarmControl();
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
            SetContentPanelControl(RegisterFarmControl.GetInstance());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(FarmListControl.GetInstance());
        }
    }

}
