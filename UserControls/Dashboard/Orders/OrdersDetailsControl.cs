using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Products;
using SkiaSharp;
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
    public partial class OrdersDetailsControl : UserControl
    {
        private static OrdersDetailsControl? Instance;
        private Order? Order;
        private List<OrderItem>? ProductList;
        private OrdersDetailsControl()
        {
            InitializeComponent();
            Products.AutoScroll = true;
        }

        public static OrdersDetailsControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new OrdersDetailsControl();
            }

            return Instance;
        }

        public async void LoadOrderInfo(Order order)
        {
            Order = order;
            NameTextBox.Text = order.Client.Name;
            EmailTextBox.Text = order.Client.Contact.Email;
            OrderDateTextBox.Text = order.OrderDate.ToString("dd/MM/yyyy");
            OrderStatusTextBox.Text = order.Status.ToString().Replace("_", " ").ToLower();
            OrderTotalTextBox.Text = order.Total.ToString();
            OrderPaymentTextBox.Text = order.PaymentMethod.Replace("_", " ").ToLower();
            OrderTotalItensTextBox.Text = order.Items.Count.ToString();
            ProductList = new List<OrderItem>(order.Items);
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductList.ForEach(async pe =>
            {
                var produto = await ProductService.GetInstance().GetById(pe.ProductId);

                OrderProductControl productControl = new OrderProductControl();

                productControl.LoadCardInfo(produto);
                Products.Controls.Add(productControl);
            });
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Order = null;
            ProductList = null;
            OrdersControl.GetInstance().SetContentPanelControl(OrderListControl.GetInstance());
        }
    }
}
