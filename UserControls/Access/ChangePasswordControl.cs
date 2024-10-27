using fazenda_verdeviva.Forms;
using fazenda_verdeviva.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Access
{
    public partial class ChangePasswordControl : UserControl
    {
        private static ChangePasswordControl? Instance;
        private ChangePasswordControl()
        {
            InitializeComponent();
        }

        public static ChangePasswordControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ChangePasswordControl();
            }

            return Instance;
        }

        private async void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            var email = EmailInputBox.Text;
            var newPassword = PasswordInputBox.Text;

            await AccessService.ChangePassword(email, newPassword);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(new LoginControl());
        }


    }
}
