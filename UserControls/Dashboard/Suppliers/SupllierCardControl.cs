using fazenda_verdeviva.Model.Entities;
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
    public partial class SupllierCardControl : UserControl
    {
        private Supplier? Supplier;
        public SupllierCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Supplier supplier)
        {
            this.Supplier = supplier;
            SupplierName.Text = supplier.Name;
            SupplierWebsite.Text = supplier.Website;
            SupllierCnoj.Text = supplier.CNPJ;
        }
    }
}
