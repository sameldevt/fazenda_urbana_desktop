using fazenda_verdeviva.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInputLabel.Text;
            var password = PasswordInputLabel.Text;

            // ação de logar

            MainForm mainForm = MainForm.GetInstance();
            mainForm.SetContentPanelControl(DashboardControl.GetInstance());
        }

        private void RequestAccessButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(new RequestAccessControl());
        }
    }
}
