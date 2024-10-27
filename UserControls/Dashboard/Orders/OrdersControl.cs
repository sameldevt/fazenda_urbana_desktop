using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
using fazenda_verdeviva.UserControls.Dashboard.Messages;
using fazenda_verdeviva.UserControls.Dashboard.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard
{
    public partial class OrdersControl : UserControl
    {
        private static OrdersControl? Instance;
        private OrdersControl()
        {
            InitializeComponent();
            OrdersList.AutoScroll = true;
            LoadOrdersCards();
        }

        public static OrdersControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new OrdersControl();
            }

            return Instance;
        }

        public async void LoadOrdersCards()
        {
            List<Order> orders = await OrderService.GetAll();

            orders.ForEach(async o =>
            {
                OrderCardControl orderCard = new OrderCardControl();

                orderCard.LoadCardInfo(o);
                OrdersList.Controls.Add(orderCard);
            });
        }
    }
}
