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
    public partial class ClientListControl : UserControl
    {
        private static ClientListControl? Instance;
        private ClientListControl()
        {
            InitializeComponent();
            ClientsList.AutoScroll = true;
            LoadClientsCards();
        }

        public static ClientListControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ClientListControl();
            }

            return Instance;
        }

        public async void LoadClientsCards()
        {
            List<Client> clients = await ClientService.GetAll();

            clients.ForEach(async p => {
                ClientCardControl clientCard = new ClientCardControl();

                await clientCard.LoadCardInfo(p);
                ClientsList.Controls.Add(clientCard);
            });
        }
    }
}
