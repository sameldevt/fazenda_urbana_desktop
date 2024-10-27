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

        private async void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
