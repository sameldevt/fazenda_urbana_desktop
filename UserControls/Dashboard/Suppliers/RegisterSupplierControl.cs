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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    public partial class RegisterSupplierControl : UserControl
    {
        private static RegisterSupplierControl? Instance;
        private Supplier Supplier = new Supplier();

        public RegisterSupplierControl()
        {
            InitializeComponent();
            AddressesList.AutoScroll = true;
        }

        public static RegisterSupplierControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterSupplierControl();
            }

            Instance.ClearSupplierInfo();
            return Instance;
        }

        private void ClearSupplierInfo()
        {
            NameTextBox.Text = string.Empty;
            CnpjTextBox.Text = string.Empty;
            WebsiteTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            StreetTextBox.Text = string.Empty;
            NumberTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            PostalcodeTextBox.Text = string.Empty;
            ComplementTextBox.Text = string.Empty;
            StateTextBox.Text = string.Empty;

            AddressesList.Controls.Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SupplierControl.GetInstance().RegisterButton.Enabled = true;
            SupplierControl.GetInstance().SetContentPanelControl(SupplierListControl.GetInstance());
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

            var supplier = new RegisterSupplierDto
            {
                Name = NameTextBox.Text,
                CNPJ = CnpjTextBox.Text,
                Website = WebsiteTextBox.Text,
                RegistrationDate = DateTime.Now,
                Contact = new Contact
                {
                    Email = EmailTextBox.Text,
                    Phone = PhoneTextBox.Text,
                },
                Addresses = addresses
            };

            await SupplierService.GetInstance().Register(supplier);

            SupplierControl.GetInstance().RegisterButton.Enabled = true;
            SupplierControl.GetInstance().SetContentPanelControl(SupplierListControl.GetInstance());
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
