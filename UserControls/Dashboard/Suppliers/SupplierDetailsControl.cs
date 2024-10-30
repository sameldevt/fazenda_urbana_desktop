using fazenda_verdeviva.Model.Entities;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    public partial class SupplierDetailsControl : UserControl
    {
        private static SupplierDetailsControl? Instance;
        private Supplier? Supplier;
        private SupplierDetailsControl()
        {
            InitializeComponent();
        }

        public static SupplierDetailsControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplierDetailsControl();
            }

            return Instance;
        }

        public void LoadSupplier(Supplier supplier)
        {
            Supplier = supplier;
            NameTextBox.Text = supplier.Name;
            CnpjTextBox.Text = supplier.CNPJ;
            WebsiteTextBox.Text = supplier.Website;
            PhoneTextBox.Text = supplier.Contact?.Phone ?? "";
            EmailTextBox.Text = supplier.Contact?.Email ?? "";
            LoadAddresses();
        }

        private void LoadAddresses()
        {
            var addresses = new List<Address>(Supplier.Addresses);

            addresses.ForEach(address =>
            {
                AddressCardControl addressCardControl = new AddressCardControl();
                addressCardControl.LoadCardInfo(address);
                Addresses.Controls.Add(addressCardControl);
            });
        }

        private void SupplierDetailsControl_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SupplierControl.GetInstance().SetContentPanelControl(SupplierListControl.GetInstance());
        }
    }
}
