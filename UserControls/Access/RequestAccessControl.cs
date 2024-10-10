using fazenda_verdeviva.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls
{
    public partial class RequestAccessControl : UserControl
    {
        public RequestAccessControl()
        {
            InitializeComponent();
        }

        private void ReturnToLoginButton_Click(object sender, EventArgs e)
        {
            MainForm accessForm = MainForm.GetInstance();   
            accessForm.SetContentPanelControl(new LoginControl());
        }
    }
}
