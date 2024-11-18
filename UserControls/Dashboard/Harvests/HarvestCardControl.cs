using fazenda_verdeviva.Model;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Harvests
{
    public partial class HarvestCardControl : UserControl
    {
        private Harvest? Harvest;

        public HarvestCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Harvest harvest)
        {
            Harvest = harvest;

            HarvestId.Text = harvest.Id.ToString();
            StartDate.Text = harvest.StartDate.ToString();
            EndDate.Text = harvest.EndDate.ToString();
            HarvestedArea.Text = harvest.HarvestedArea.ToString();
            HarvestedQuantity.Text = harvest.HarvestedQuantity.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editHarvestControlInstance = HarvestDetailsControl.GetInstance();
            editHarvestControlInstance.LoadHarvestInfo(Harvest);
            HarvestControl.GetInstance().SetContentPanelControl(editHarvestControlInstance);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await HarvestService.GetInstance().Delete(Harvest!.Id);
            HarvestListControl.GetInstance().HarvestsList.Controls.Remove(this);
        }
    }

}
