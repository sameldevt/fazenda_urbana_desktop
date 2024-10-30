using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
using fazenda_verdeviva.UserControls.Dashboard.Products;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    public partial class OrderListControl : UserControl, ControlInterface
    {
        private static OrderListControl? Instance;
        public OrderListControl()
        {
            InitializeComponent();
            OrderList.AutoScroll = true;
        }

        public static OrderListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new OrderListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            OrderList.Controls.Clear();

            List<Order> orders = await OrderService.GetInstance().GetAll();

            try
            {
                orders.ForEach(o =>
                {
                    OrderCardControl orderCard = new OrderCardControl();
                    orderCard.LoadCardInfo(o);
                    OrderList.Controls.Add(orderCard);
                });
            }
            catch (Exception ex)
            {
                OrdersControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
