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

namespace fazenda_verdeviva.UserControls.Dashboard.Common
{
    public partial class AddressCardControl : UserControl
    {       
        public AddressCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Address address)
        {
            Street.Text = address.Street;
            City.Text = address.City;
            Number.Text = address.Number;
            PostalCode.Text = address.PostalCode;
            Complement.Text = address.Complement;
            State.Text = address.State;
        }
    }
}
