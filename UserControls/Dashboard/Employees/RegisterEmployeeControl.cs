using fazenda_verdeviva.Model.Dto;
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
    public partial class RegisterEmployeeControl : UserControl
    {
        private static RegisterEmployeeControl Instance;
        private Employee Employee = new Employee();

        public RegisterEmployeeControl()
        {
            InitializeComponent();
            AddressesList.AutoScroll = true;
        }

        public static RegisterEmployeeControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterEmployeeControl();
            }

            Instance.ClearEmployeeInfos();
            return Instance;
        }

        private void ClearEmployeeInfos()
        {
            NameTextBox.Text = string.Empty;
            PositionTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            AddressesList.Controls.Clear();
            StreetTextBox.Controls.Clear();
            NumberTextBox.Controls.Clear();
            CityTextBox.Controls.Clear();
            PostalcodeTextBox.Controls.Clear();
            ComplementTextBox.Controls.Clear();
            StateTextBox.Controls.Clear();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var addresses = new List<Address>();

            foreach (var c in AddressesList.Controls)
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

                    addresses.Add(Address);
                }
            }

            var employee = new RegisterEmployeeDto
            {
                Name = NameTextBox.Text,
                Password = "senhapadrao",
                Position = PositionTextBox.Text,
                Contact = new Contact
                {
                    Email = EmailTextBox.Text,
                    Phone = PhoneTextBox.Text,
                },
                Addresses = addresses,
            };

            await EmployeeService.GetInstance().Register(employee);

            EmployeeControl.GetInstance().RegisterButton.Enabled = true;
            EmployeeControl.GetInstance().SetContentPanelControl(EmployeeListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeControl.GetInstance().RegisterButton.Enabled = true;
            EmployeeControl.GetInstance().SetContentPanelControl(EmployeeListControl.GetInstance());
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            var addressCard = new AddressCardControl();
            addressCard.LoadCardInfo(new Address
            {
                Street = StreetTextBox.Text,
                Number = NumberTextBox.Text,
                City = CityTextBox.Text,
                PostalCode = PostalcodeTextBox.Text,
                Complement = ComplementTextBox.Text,
                State = StateTextBox.Text
            });
            StreetTextBox.Text = "";
            NumberTextBox.Text = "";
            CityTextBox.Text = "";
            PostalcodeTextBox.Text = "";
            ComplementTextBox.Text = "";
            StateTextBox.Text = "";
            AddressesList.Controls.Add(addressCard);
        }
    }
}
