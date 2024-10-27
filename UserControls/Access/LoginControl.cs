using fazenda_verdeviva.Forms;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Access;
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInputLabel.Text;
            var password = PasswordInputLabel.Text;

            //await AccessService.Login(email, password);

            MainForm mainForm = MainForm.GetInstance();
            mainForm.SetContentPanelControl(DashboardControl.GetInstance());
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = MainForm.GetInstance();
            mainForm.SetContentPanelControl(RegisterControl.GetInstance());
        }

        private void ForgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(ChangePasswordControl.GetInstance());
        }
    }
}
