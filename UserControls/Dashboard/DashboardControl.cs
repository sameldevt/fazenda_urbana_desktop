using fazenda_verdeviva.Forms;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.UserControls.Dashboard;
using fazenda_verdeviva.UserControls.Dashboard.Cultures;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
using fazenda_verdeviva.UserControls.Dashboard.Equipments;
using fazenda_verdeviva.UserControls.Dashboard.Farms;
using fazenda_verdeviva.UserControls.Dashboard.Harvests;
using fazenda_verdeviva.UserControls.Dashboard.Messages;
using fazenda_verdeviva.UserControls.Dashboard.Products;
using fazenda_verdeviva.UserControls.Dashboard.Reports;
using fazenda_verdeviva.UserControls.Dashboard.Suppliers;
using fazenda_verdeviva.UserControls.Dashboard.Supplies;
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
    public partial class DashboardControl : UserControl
    {
        private static DashboardControl instance;
        public Employee? Employee;

        private DashboardControl()
        {
            InitializeComponent();

            Controls.Add(ContentPanel);

            SetContentPanelControl(ProductsControl.GetInstance());
        }

        public static DashboardControl GetInstance()
        {
            if (instance == null)
            {
                instance = new DashboardControl();
            }

            return instance;
        }

        public void SaveUser(Employee employee)
        {
            Employee = employee;
            OperatorEmail.Text = employee.Contact.Email;
        }

        public void SetContentPanelControl(UserControl control)
        {
            ContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(control);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(ProductsControl.GetInstance());
        }

        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(SupplierControl.GetInstance());
        }

        private void OrdersButton_Click_1(object sender, EventArgs e)
        {
            SetContentPanelControl(OrdersControl.GetInstance());

        }

        private void ClientsButton_Click_1(object sender, EventArgs e)
        {
            SetContentPanelControl(ClientControl.GetInstance());
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(ContactMessageControl.GetInstance());
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(EmployeeControl.GetInstance());
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void HarvestButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(HarvestControl.GetInstance());
        }

        private void CultureButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(CultureControl.GetInstance());
        }

        private void FarmButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(FarmControl.GetInstance());
        }

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(EquipmentControl.GetInstance());
        }

        private void SupplyButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(SupplyControl.GetInstance());

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var mainFormInstance = MainForm.GetInstance();
            mainFormInstance.DeleteEmployeeInfo();
            mainFormInstance.SetContentPanelControl(LoginControl.GetInstance());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            SetContentPanelControl(ReportControl.GetInstance());

        }
    }
}
