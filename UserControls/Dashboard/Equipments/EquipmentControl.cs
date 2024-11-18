using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    public partial class EquipmentControl : UserControl
    {
        private static EquipmentControl? Instance;

        private EquipmentControl()
        {
            InitializeComponent();
            Controls.Add(ContentPanel);
            SetContentPanelControl(EquipmentListControl.GetInstance());
        }

        public static EquipmentControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EquipmentControl();
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
            SetContentPanelControl(RegisterEquipmentControl.GetInstance());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(EquipmentListControl.GetInstance());
        }
    }

}
