using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
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
    public partial class ReportsListControl : UserControl
    {
        private static ReportsListControl Instance;
        private ReportsListControl()
        {
            InitializeComponent();
            ReportsList.AutoScroll = true;
        }

        public static ReportsListControl GetInstance() 
        { 
            if(Instance == null)
            {
                Instance = new ReportsListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            ReportsList.Controls.Clear();

            List<Report> reports = await ReportService.GetInstance().GetAll();

            try
            {
                reports.ForEach(report =>
                {
                    ReportCardControl reportCard = new ReportCardControl();
                    reportCard.LoadCardInfo(report);
                    ReportsList.Controls.Add(reportCard);
                });
            }
            catch (Exception ex)
            {
                ReportControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
