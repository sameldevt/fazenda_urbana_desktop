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

namespace fazenda_verdeviva.UserControls.Dashboard.Reports
{
    public partial class ReportCardControl : UserControl
    {
        private Report Report;
        public ReportCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Report report)
        {
            this.Report = report;
        }
    }
}
