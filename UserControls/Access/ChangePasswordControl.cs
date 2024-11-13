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

            Instance.ClearInputs();
            return Instance;
        }

        private void ClearInputs()
        {
            EmailInputBox.Text = string.Empty;
            PasswordInputBox.Text = string.Empty;
            ConfirmPasswordInputBox.Text = string.Empty;
        }

        private async void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (EmailInputBox.Text == "")
            {
                MessageBox.Show("Por favor, digite um e-mail.");
                return;
            }

            if (PasswordInputBox.Text == "")
            {
                MessageBox.Show("Por favor, digite uma senha.");
                return;
            }

            if(ConfirmPasswordInputBox.Text == "")
            {
                MessageBox.Show("Por favor, digite a confirmação da senha.");
                return;
            }

            if(PasswordInputBox.Text != ConfirmPasswordInputBox.Text)
            {
                MessageBox.Show("As senhas digitas precisam ser iguais.");
                return;
            }

            var email = EmailInputBox.Text;
            var newPassword = PasswordInputBox.Text;

            var response = await AccessService.ChangePassword(email, newPassword);

            if (response)
            {
                MainForm accessForm = MainForm.GetInstance();
                accessForm.SetContentPanelControl(LoginControl.GetInstance());
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(LoginControl.GetInstance());
        }


    }
}
