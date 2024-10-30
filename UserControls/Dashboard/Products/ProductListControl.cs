using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    public partial class ProductListControl : UserControl, ControlInterface
    {
        private static ProductListControl? Instance;

        private ProductListControl()
        {
            InitializeComponent();
            ProductsList.AutoScroll = true;
        }

        public static ProductListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ProductListControl();
            }

            Instance.LoadCards(); 
            return Instance;
        }

        public async Task LoadCards()
        {
            ProductsList.Controls.Clear();

            List<Product> products = await ProductService.GetInstance().GetAll();

            try
            {
                products.ForEach(p =>
                {
                    ProductCardControl productCard = new ProductCardControl();
                    productCard.LoadCardInfo(p);
                    ProductsList.Controls.Add(productCard);
                });
            }
            catch (Exception ex) 
            { 
                ProductsControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
