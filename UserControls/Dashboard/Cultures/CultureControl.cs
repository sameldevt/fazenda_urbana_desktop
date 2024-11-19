using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    public partial class CultureControl : UserControl
    {
        private static CultureControl? Instance;

        private CultureControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(CultureListControl.GetInstance());
        }

        public static CultureControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CultureControl();
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
            SetContentPanelControl(CultureListControl.GetInstance());
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            SetContentPanelControl(RegisterCultureControl.GetInstance());
        }
    }
}
