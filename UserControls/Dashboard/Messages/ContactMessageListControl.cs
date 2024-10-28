using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    public partial class ContactMessageListControl : UserControl
    {
        private static ContactMessageListControl? Instance;
        public ContactMessageListControl()
        {
            InitializeComponent();
            MessagesList.AutoScroll = true;
            LoadMessageCards();
        }

        public static ContactMessageListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ContactMessageListControl();
            }
            return Instance;
        }

        public async void LoadMessageCards()
        {
            List<ContactMessage> messages = await ContactMessageService.GetAll();

            messages.ForEach(async m =>
            {
                ContactMessageCardControl messageCard = new ContactMessageCardControl();

                messageCard.LoadCardInfo(m);
                MessagesList.Controls.Add(messageCard);
            });
        }
    }
}
