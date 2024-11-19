using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Farms;
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
    public partial class HarvestDetailsControl : UserControl
    {
        private static HarvestDetailsControl Instance;
        private Harvest Harvest;

        private HarvestDetailsControl()
        {
            InitializeComponent();
        }

        public static HarvestDetailsControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new HarvestDetailsControl();
            }

            Instance.ClearHarvestInfo();
            return Instance;
        }

        public async void LoadHarvestInfo(Harvest harvest)
        {
            Harvest = harvest;
            IdTextBox.Text = harvest.Id.ToString();
            StartDate.Value = harvest.StartDate;
            EndDate.Value = harvest.EndDate;
            HarvestedArea.Text = harvest.HarvestedArea.ToString();
            HarvestedQuantity.Text = harvest.HarvestedQuantity.ToString();

            var culture = await CultureService.GetInstance().GetById(harvest.CultureId);

            CultureName.Text = culture.Name;
            CultureType.Text = culture.Type.ToString();
            CultureCycle.Text = culture.Cycle.ToString();

            var farm = await FarmService.GetInstance().GetById(culture.FarmId);

            FarmName.Text = farm.Name;
            FarmLocation.Text = farm.Location;

            var produto = await ProductService.GetInstance().GetById(harvest.ProductId);

            ProductName.Text = produto.Name;
        }

        public void ClearHarvestInfo()
        {
            Harvest = null;

            IdTextBox.Text = string.Empty;
            HarvestedArea.Text = string.Empty;
            HarvestedQuantity.Text = string.Empty;

            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;

            CultureName.Text = string.Empty;
            CultureType.Text = string.Empty;
            CultureCycle.Text = string.Empty;

            FarmName.Text = string.Empty;
            FarmLocation.Text = string.Empty;

            ProductName.Text = string.Empty;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HarvestControl.GetInstance().SetContentPanelControl(HarvestListControl.GetInstance());
        }
    }
}
