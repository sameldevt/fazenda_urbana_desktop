using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
using fazenda_verdeviva.UserControls.Dashboard.Employees;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    public partial class ContactMessageListControl : UserControl, ControlInterface
    {
        private static ContactMessageListControl? Instance;
        public ContactMessageListControl()
        {
            InitializeComponent();
            MessagesList.AutoScroll = true;
        }

        public static ContactMessageListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ContactMessageListControl();
            }

            Instance.Refresh();
            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            MessagesList.Controls.Clear();

            List<ContactMessage> messages = await ContactMessageService.GetInstance().GetAll();

            try
            {
                messages.ForEach(async m =>
                {
                    ContactMessageCardControl messageCard = new ContactMessageCardControl();

                    messageCard.LoadCardInfo(m);
                    MessagesList.Controls.Add(messageCard);
                });
            }
            catch (Exception ex)
            {
                ContactMessageControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
