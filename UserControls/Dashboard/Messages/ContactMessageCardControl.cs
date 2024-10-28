using fazenda_verdeviva.Model.Entities;
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
    public partial class ContactMessageCardControl : UserControl
    {
        private ContactMessage? ContactMessage;
        public ContactMessageCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(ContactMessage contactMessage)
        {
            this.ContactMessage = contactMessage;
            MessageContent.Text = contactMessage.Content;
            UserName.Text = contactMessage.UserName;
            UserEmail.Text = contactMessage.UserEmail;
            MessageDate.Text = contactMessage.Date.ToString("dd/MM/yyyy");
        }
    }
}
