using fazenda_verdeviva.UserControls.Dashboard.Employees;
using fazenda_verdeviva.UserControls.Dashboard.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    public partial class ContactMessageControl : UserControl
    {
        private static ContactMessageControl? Instance;
        private ContactMessageControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(ContactMessageListControl.GetInstance());
        }

        public static ContactMessageControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ContactMessageControl();
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
            SetContentPanelControl(ContactMessageListControl.GetInstance());
        }
    }
}
