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
    public partial class EditClientControl : UserControl
    {
        private static EditClientControl? Instance;
        private Client? Client;

        private EditClientControl()
        {
            InitializeComponent();
            
        }

        public static EditClientControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditClientControl();
            }

            return Instance;
        }

        public void LoadClientInfo(Client client)
        {
            this.Client = client;
            NameTextBox.Text = client.Name;
            PhoneTextBox.Text = client.Contact.Phone;
            EmailTextBox.Text = client.Contact.Email;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Client = null;
            ClientControl.GetInstance().SetContentPanelControl(ClientListControl.GetInstance());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Client.Name = NameTextBox.Text;
            Client.Contact.Phone = PhoneTextBox.Text;
            Client.Contact.Email = EmailTextBox.Text;

            var response = await ClientService.GetInstance().Update(Client);

            MessageBox.Show(response);
            ClientControl.GetInstance().SetContentPanelControl(ClientListControl.GetInstance());

        }
    }
}
