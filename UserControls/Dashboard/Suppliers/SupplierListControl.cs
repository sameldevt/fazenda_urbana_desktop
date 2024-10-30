using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
using fazenda_verdeviva.UserControls.Utils;
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
    public partial class SupplierListControl : UserControl, ControlInterface
    {
        private static SupplierListControl? Instance;

        private SupplierListControl()
        {
            InitializeComponent();
            SupplierList.AutoScroll = true;
        }

        public static SupplierListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplierListControl();
            }

            Instance.Refresh();
            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            SupplierList.Controls.Clear();

            List<Supplier> suppliers = await SupplierService.GetInstance().GetAll();

            try
            {
                suppliers.ForEach(s =>
                {
                    SupplierCardControl supplierCard = new SupplierCardControl();

                    supplierCard.LoadCardInfo(s);
                    SupplierList.Controls.Add(supplierCard);
                });
            }
            catch (Exception ex)
            {
                SupplierControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
