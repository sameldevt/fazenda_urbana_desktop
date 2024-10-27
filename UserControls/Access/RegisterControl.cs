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

            return Instance;
        }
        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var name = NameInputBox.Text;
            var email = EmailInputBox.Text;
            var password = PasswordInputBox.Text;

            await AccessService.Register(name, email, password);
        }
        private void ReturnToLoginButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();
            accessForm.SetContentPanelControl(new LoginControl());
        }
    }
}
