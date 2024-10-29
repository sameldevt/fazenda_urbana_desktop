using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    public partial class ClientCardControl : UserControl
    {
        private Client? Client;

        public ClientCardControl()
        {
            InitializeComponent();
        }

        public async Task LoadCardInfo(Client client)
        {
            this.Client = client;
            ClientName.Text = client.Name;
            ClientMemberSinceDate.Text = $"Membro desde {client.RegistrationDate.ToString("dd/MM/yyyy")}";
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var clientDetailsControlInstance = ClientDetailsControl.GetInstance();
            clientDetailsControlInstance.LoadClient(Client);
            ClientControl.GetInstance().SetContentPanelControl(clientDetailsControlInstance);
        }

        private async void DeleteButton_Click_1(object sender, EventArgs e)
        {
            var response = await ClientService.Delete(Client!.Id);

            MessageBox.Show(response);

            ProductListControl.GetInstance().ProductsList.Controls.Remove(this);
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            var editClientControlInstance = EditClientControl.GetInstance();
            editClientControlInstance.LoadClientInfo(Client);
            ProductsControl.GetInstance().SetContentPanelControl(editClientControlInstance);
        }
    }
}
