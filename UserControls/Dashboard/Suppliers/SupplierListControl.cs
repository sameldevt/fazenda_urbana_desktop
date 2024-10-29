using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
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
    public partial class SupplierListControl : UserControl
    {
        private static SupplierListControl? Instance;

        public SupplierListControl()
        {
            InitializeComponent();
            SupplierList.AutoScroll = true;
            LoadSupplierCards();
        }

        public static SupplierListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplierListControl();
            }

            Instance.LoadSupplierCards();
            return Instance;
        }

        public async void LoadSupplierCards()
        {
            SupplierList.Controls.Clear();

            List<Supplier> suppliers = await SupplierService.GetAll();

            suppliers.ForEach(s =>
            {
                SupplierCardControl supplierCard = new SupplierCardControl();

                supplierCard.LoadCardInfo(s);
                SupplierList.Controls.Add(supplierCard);
            });
        }
    }
}
