using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    public partial class EditSupplierControl : UserControl
    {
        private static EditSupplierControl? Instance;
        private Supplier? Supplier;

        public EditSupplierControl()
        {
            InitializeComponent();
            Addresses.AutoScroll = true;
        }

        public static EditSupplierControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditSupplierControl();
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

            Addresses.Controls.Clear();
        }

        public void LoadSupplier(Supplier supplier)
        {
            this.Supplier = supplier;
            NameTextBox.Text = supplier.Name;
            WebsiteTextBox.Text = supplier.Website;
            CnpjTextBox.Text = supplier.CNPJ;
            PhoneTextBox.Text = supplier.Contact?.Phone ?? "";
            EmailTextBox.Text = supplier.Contact?.Email ?? "";
            LoadAddressCards(supplier);
        }

        public void LoadAddressCards(Supplier supplier)
        {
            foreach (var address in supplier.Addresses)
            {
                AddressCardControl addressCard = new AddressCardControl();
                addressCard.LoadCardInfo(address);
                Addresses.Controls.Add(addressCard);
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Supplier.Name = NameTextBox.Text;
            Supplier.Website = WebsiteTextBox.Text;
            Supplier.CNPJ = CnpjTextBox.Text;
            Supplier.Contact.Phone = PhoneTextBox.Text;
            Supplier.Contact.Email = EmailTextBox.Text;

            await SupplierService.GetInstance().Update(Supplier);

            MessageBox.Show("Fornecedor editado com sucesso.");

            SupplierControl.GetInstance().RegisterButton.Enabled = true;
            SupplierControl.GetInstance().SetContentPanelControl(SupplierListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SupplierControl.GetInstance().RegisterButton.Enabled = true;
            SupplierControl.GetInstance().SetContentPanelControl(SupplierListControl.GetInstance());
        }
    }
}
