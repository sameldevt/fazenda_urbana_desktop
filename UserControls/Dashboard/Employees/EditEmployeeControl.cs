using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
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
    public partial class EditEmployeeControl : UserControl
    {
        private static EditEmployeeControl Instance;
        private Employee Employee;

        private EditEmployeeControl()
        {
            InitializeComponent();
        }

        public static EditEmployeeControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditEmployeeControl();
            }

            return Instance;
        }

        public void LoadEmployeeInfo(Employee employee)
        {
            Employee = employee;
            NameTextBox.Text = employee.Name;
            PositionTextBox.Text = employee.Position;
            RegistrationNumberTextBox.Text = employee.RegistrationNumber;
            PhoneTextBox.Text = employee.Contact.Phone;
            EmailTextBox.Text = employee.Contact.Email;
            LoadAddressCards(employee);
        }

        public void LoadAddressCards(Employee employee)
        {
            foreach (var address in employee.Addresses)
            {
                AddressCardControl addressCard = new AddressCardControl();
                addressCard.LoadCardInfo(address);
                Addresses.Controls.Add(addressCard);
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Employee.Name = NameTextBox.Text;
            Employee.Position = PositionTextBox.Text;
            Employee.RegistrationNumber = RegistrationNumberTextBox.Text;
            Employee.Contact.Phone = PhoneTextBox.Text;
            Employee.Contact.Email = EmailTextBox.Text;

            foreach (var c in Addresses.Controls)
            {
                if (c is AddressCardControl control)
                {
                    var Address = new Address
                    {
                        Street = control.Street.Text,
                        Number = control.Number.Text,
                        City = control.City.Text,
                        PostalCode = control.PostalCode.Text,
                        Complement = control.Complement.Text,
                        State = control.State.Text
                    };

                    Employee.Addresses.Add(Address);
                }
            }

            await EmployeeService.GetInstance().Update(Employee);

            EmployeeControl.GetInstance().RegisterButton.Enabled = true;
            EmployeeControl.GetInstance().SetContentPanelControl(EmployeeListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeControl.GetInstance().RegisterButton.Enabled = true;
            EmployeeControl.GetInstance().SetContentPanelControl(EmployeeListControl.GetInstance());
        }
    }
}
