using fazenda_verdeviva.Model.Entities;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    public partial class OrderCardControl : UserControl
    {
        private Order? Order;
        public OrderCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Order order)
        {
            this.Order = order;
            OrderId.Text = $"# {order.Id.ToString().PadLeft(10, '0')}";
            OrderItemQuantity.Text = $"Quantidade de itens: {order.Items.Count.ToString()}";
            OrderPrice.Text = $"R$ {order.Total.ToString().Replace('.', ',')}";
            PaymentMethod.Text = order.PaymentMethod;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            var orderDetailsControlInstance = OrdersDetailsControl.GetInstance();
            orderDetailsControlInstance.LoadOrderInfo(Order);
            OrdersControl.GetInstance().SetContentPanelControl(orderDetailsControlInstance);
        }
    }
}
