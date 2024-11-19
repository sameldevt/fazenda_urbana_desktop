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

            HarvestId.Text = harvest.Id.ToString().PadLeft(10, '0');
            StartDate.Text = harvest.StartDate.ToString("dd/MM/yyyy");
            EndDate.Text = harvest.EndDate.ToString("dd/MM/yyyy");
            HarvestedArea.Text = $"{harvest.HarvestedArea.ToString()} m²";
            HarvestedQuantity.Text = $"{harvest.HarvestedQuantity.ToString()} kg";
        }

        private void Details_Click(object sender, EventArgs e)
        {
            var editHarvestControlInstance = HarvestDetailsControl.GetInstance();
            editHarvestControlInstance.LoadHarvestInfo(Harvest);
            HarvestControl.GetInstance().SetContentPanelControl(editHarvestControlInstance);

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await ColheitaService.GetInstance().Delete(Harvest!.Id);
            HarvestListControl.GetInstance().HarvestsList.Controls.Remove(this);
        }
    }

}
