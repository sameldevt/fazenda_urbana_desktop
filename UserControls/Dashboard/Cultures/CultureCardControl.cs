using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    public partial class CultureCardControl : UserControl
    {
        private Culture? Culture;

        public CultureCardControl()
        {
            InitializeComponent();
        }

        public async Task LoadCardInfo(Culture culture)
        {
            this.Culture = culture;
            CultureName.Text = Culture.Name;
            Type.Text = Culture.Type.ToString();
            Cycle.Text = Culture.Cycle.ToString();
            PlantingDate.Text = Culture.PlantingDate.ToString("dd/MM/yyyy");
            EstimatedHarvestDate.Text = Culture.EstimatedHarvestDate.ToString("dd/MM/yyyy");

            var farm = await FarmService.GetInstance().GetById(culture.FarmId);
            Farm.Text = farm.Name;
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var cultureDetailsControlInstance = EditCultureControl.GetInstance();
            cultureDetailsControlInstance.LoadCultureInfo(Culture);
            CultureControl.GetInstance().SetContentPanelControl(cultureDetailsControlInstance);
        }
    }
}
