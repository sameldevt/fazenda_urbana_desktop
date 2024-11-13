using fazenda_verdeviva.Forms;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Access;
using Newtonsoft.Json;
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
        private static LoginControl Instance;

        private LoginControl()
        {
            InitializeComponent();
        }

        public static LoginControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new LoginControl();
            }

            return Instance;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInputBox.Text;
            var password = PasswordInputBox.Text;

            var employee = await AccessService.Login(email, password);

            if (employee != null)
            {
                var dashboardControl = DashboardControl.GetInstance();
                dashboardControl.SaveUser(employee);
                SaveEmployeeInfo(employee);
                MainForm.GetInstance().SetContentPanelControl(dashboardControl);
            }
        }

        private void SaveEmployeeInfo(Employee employee)
        {
            if (!Directory.Exists("Employee"))
            {
                Directory.CreateDirectory("Employee");
            }

            string jsonString = JsonConvert.SerializeObject(employee, Formatting.Indented);
            File.WriteAllText("Employee/employee.json", jsonString);

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
