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

namespace fazenda_verdeviva.UserControls.Dashboard.Common
{
    public partial class NoResourceFound : UserControl
    {
        private static NoResourceFound? Instance;
        private NoResourceFound()
        {
            InitializeComponent();
        }

        public static NoResourceFound GetInstance()
        {
            if (Instance == null)
            {
                Instance = new NoResourceFound();
            }

            return Instance;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
        }
    }
}
