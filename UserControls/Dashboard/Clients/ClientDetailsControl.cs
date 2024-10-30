using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
using fazenda_verdeviva.UserControls.Dashboard.Orders;
using fazenda_verdeviva.UserControls.Dashboard.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    public partial class ClientDetailsControl : UserControl
    {
        private static ClientDetailsControl? Instance;
        private Client? Client;

        private ClientDetailsControl()
        {
            InitializeComponent();
            Addresses.AutoScroll = true;
        }

        public static ClientDetailsControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ClientDetailsControl();
            }

            return Instance;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Client = null;
            Addresses.Controls.Clear();
            ClientControl.GetInstance().SetContentPanelControl(ClientListControl.GetInstance());
        }

        public void LoadClient(Client client)
        {
            this.Client = client;
            NameTextBox.Text = client.Name;
            PhoneTextBox.Text = client.Contact?.Phone ?? "";
            EmailTextBox.Text = client.Contact?.Email ?? "";
            LoadAddressCards(client);
        }

        public void LoadAddressCards(Client client)
        {
            foreach (var address in client.Addresses)
            {
                AddressCardControl addressCard = new AddressCardControl();
                addressCard.LoadCardInfo(address);
                Addresses.Controls.Add(addressCard);
            }
        }

        private void ClientDetailsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
