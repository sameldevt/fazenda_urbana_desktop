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

namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    public partial class SupplierCardControl : UserControl
    {
        private Supplier? Supplier;

        public SupplierCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Supplier supplier)
        {
            this.Supplier = supplier;
            SupplierName.Text = supplier.Name;
            SupplierWebsite.Text = supplier.Website;
            SupllierCnpj.Text = supplier.CNPJ;
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            var editSupplierControl = EditSupplierControl.GetInstance();
            editSupplierControl.LoadSupplier(Supplier);
            SupplierControl.GetInstance().SetContentPanelControl(editSupplierControl);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var response = await SupplierService.Delete(Supplier!.Id);

            MessageBox.Show(response);

            SupplierListControl.GetInstance().SupplierList.Controls.Remove(this);
        }
    }
}
