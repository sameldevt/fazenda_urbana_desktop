using fazenda_verdeviva.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.Forms
{
    public partial class MainForm : Form
    {
        private Panel contentPanel;
        private static MainForm instance;

        private MainForm()
        {
            InitializeComponent(); 

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill 
            };

            Controls.Add(contentPanel);

            SetContentPanelControl(new LoginControl());
        }

        public static MainForm GetInstance()
        {
            if(instance == null)
            {
                instance = new MainForm();
            }
            return instance;
        }

        public void SetContentPanelControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }

}
