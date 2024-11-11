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
        public LoginControl()
        {
            InitializeComponent();

            var employee = LoadEmployeeInfo();

            if (employee != null)
            {
                var dashboardControl = DashboardControl.GetInstance();
                MainForm.GetInstance().SetContentPanelControl(dashboardControl);
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInputBox.Text;
            var password = PasswordInputBox.Text;
            MainForm.GetInstance().SetContentPanelControl(DashboardControl.GetInstance());

            var response = await AccessService.Login(email, password);

            if (response)
            {
                var dashboardControl = DashboardControl.GetInstance();
                SaveEmployeeInfo(dashboardControl.Employee);
                MainForm.GetInstance().SetContentPanelControl(dashboardControl);
            }
        }

        private void SaveEmployeeInfo(Employee employee)
        {
            Directory.CreateDirectory("Operator");
            string jsonString = JsonConvert.SerializeObject(employee, Formatting.Indented);
            File.WriteAllText("Operator/employee.json", jsonString);
        }

        private Employee LoadEmployeeInfo()
        {
            if (File.Exists("Operator/employee.json"))
            {
                string jsonString = File.ReadAllText("Operator/employee.json");
                Employee employee = JsonConvert.DeserializeObject<Employee>(jsonString);

                return employee;
            }
            else
            {
                return null;
            }
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
