using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Harvests
{
    public partial class HarvestControl : UserControl
    {
        private static HarvestControl? Instance;

        private HarvestControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(HarvestListControl.GetInstance());
        }

        public static HarvestControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new HarvestControl();
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
            SetContentPanelControl(RegisterHarvestControl.GetInstance());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(HarvestListControl.GetInstance());
        }
    }
}
