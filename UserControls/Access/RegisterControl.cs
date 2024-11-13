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

namespace fazenda_verdeviva.UserControls
{
    public partial class RegisterControl : UserControl
    {
        private static RegisterControl? Instance;
        private RegisterControl()
        {
            InitializeComponent();
        }

        public static RegisterControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterControl();
            }

            Instance.ClearInputs();
            return Instance;
        }

        private void ClearInputs()
        {
            NameInputBox.Text = string.Empty;
            EmailInputBox.Text = string.Empty;
            PasswordInputBox.Text = string.Empty;
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            if (NameInputBox.Text == "")
            {
                MessageBox.Show("Por favor, digite o seu nome.");
                return;
            }

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

            var name = NameInputBox.Text;
            var email = EmailInputBox.Text;
            var password = PasswordInputBox.Text;

            var response = await AccessService.Register(name, email, password);

            if (response)
            {
                MainForm accessForm = MainForm.GetInstance();
                accessForm.SetContentPanelControl(LoginControl.GetInstance());
            }       
        }
        private void ReturnToLoginButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(LoginControl.GetInstance());
        }

        private void PasswordInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
