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

namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    public partial class ClientListControl : UserControl, ControlInterface
    {
        private static ClientListControl? Instance;
        private ClientListControl()
        {
            InitializeComponent();
            ClientsList.AutoScroll = true;
        }

        public static ClientListControl GetInstance()
        {
            if(Instance == null)
            {
                Instance = new ClientListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            ClientsList.Controls.Clear();

            List<Client> clients = await ClientService.GetInstance().GetAll();

            try
            {
                clients.ForEach(async p =>
                {
                    ClientCardControl clientCard = new ClientCardControl();

                    await clientCard.LoadCardInfo(p);
                    ClientsList.Controls.Add(clientCard);
                });
            }
            catch (Exception ex) 
            {
                ClientControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
