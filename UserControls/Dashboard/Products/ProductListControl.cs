using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
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
    public partial class ProductListControl : UserControl
    {
        private static ProductListControl? Instance;
        private ProductListControl()
        {
            InitializeComponent();
            ProductsList.AutoScroll = true;
            LoadProductCards();
        }

        public static ProductListControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ProductListControl();
            }
            return Instance;
        }

        public async void LoadProductCards()
        {
            List<Product> products = await ProductService.GetAll();

            products.ForEach(async p => {
                ProductCardControl productCard = new ProductCardControl();

                await productCard.LoadCardInfo(p);
                ProductsList.Controls.Add(productCard);
            });
        }
    }
}
