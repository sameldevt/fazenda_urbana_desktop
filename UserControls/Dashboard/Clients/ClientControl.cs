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

namespace fazenda_verdeviva.UserControls.Dashboard
{
    public partial class ClientControl : UserControl
    {
        private static ClientControl? Instance;
        private ClientControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(ClientListControl.GetInstance());
        }

        public static ClientControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ClientControl();
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
    }
}
