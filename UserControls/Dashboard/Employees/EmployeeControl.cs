using fazenda_verdeviva.UserControls.Dashboard.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Employees
{
    public partial class EmployeeControl : UserControl
    {
        private static EmployeeControl? Instance;
        private EmployeeControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(EmployeeListControl.GetInstance());
        }

        public static EmployeeControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EmployeeControl();
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
            SetContentPanelControl(RegisterEmployeeControl.GetInstance());
        }
    }
}
