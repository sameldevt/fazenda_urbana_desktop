using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.UserControls;
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

namespace fazenda_verdeviva.Forms
{
    public partial class MainForm : Form
    {
        private Panel contentPanel;
        private static MainForm instance;

        private MainForm()
        {
            InitializeComponent();
            this.Text = "Fazenda VerdeViva";
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(contentPanel);
        }

        public static MainForm GetInstance()
        {
            if(instance == null)
            {
                instance = new MainForm();
            }

            //instance.SetContentPanelControl(DashboardControl.GetInstance());
            LoadEmployeeInfo();

            return instance;
        }

        private static void LoadEmployeeInfo()
        {
            if (File.Exists("Employee/employee.json"))
            {
                string jsonString = File.ReadAllText("Employee/employee.json");
                Employee employee = JsonConvert.DeserializeObject<Employee>(jsonString);

                var dashboardControl = DashboardControl.GetInstance();
                dashboardControl.SaveUser(employee);
                instance.SetContentPanelControl(dashboardControl);
            }
            else
            {
                instance.SetContentPanelControl(LoginControl.GetInstance());
            }
        }

        public void DeleteEmployeeInfo()
        {
            string filePath = "Employee/employee.json";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public void SetContentPanelControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }

}
