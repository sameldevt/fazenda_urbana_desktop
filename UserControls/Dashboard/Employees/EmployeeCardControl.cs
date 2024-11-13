using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Employees
{
    public partial class EmployeeCardControl : UserControl
    {
        private Employee? Employee;
        public EmployeeCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Employee employee)
        {
            this.Employee = employee;
            EmployeeName.Text = employee.Name;
            PositionLabel.Text = employee.Position;
            RegistrationNumberLabel.Text = employee.RegistrationNumber;
            EmployeeEmail.Text = employee.Contact.Email;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editEmployeeControlInstance = EditEmployeeControl.GetInstance();
            editEmployeeControlInstance.LoadEmployeeInfo(Employee);
            EmployeeControl.GetInstance().SetContentPanelControl(editEmployeeControlInstance);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await EmployeeService.GetInstance().Delete(Employee!.Id);
            EmployeeListControl.GetInstance().EmployeesList.Controls.Remove(this);
        }
    }
}
