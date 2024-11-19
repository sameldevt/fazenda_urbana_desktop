using fazenda_verdeviva.Model;
using fazenda_verdeviva.Model.Dto;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    public partial class EditCultureControl : UserControl
    {
        private static EditCultureControl? Instance;
        private Culture? Culture;

        private EditCultureControl()
        {
            InitializeComponent();
        }

        public static EditCultureControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditCultureControl();
            }

            Instance.LoadTypes();
            Instance.LoadCycles();
            return Instance;
        }

        public void LoadCultureInfo(Culture culture)
        {
            this.Culture = culture;
            CultureName.Text = culture.Name;
            TypeComboBox.Text = culture.Type.ToString();
            CycleComboBox.Text = culture.Cycle.ToString();
            PlantingDate.Text = culture.PlantingDate.ToString("dd/MM/yyyy");
            EstimatedHarvestDate.Text = culture.EstimatedHarvestDate.ToString("dd/MM/yyyy");
        }

        public void LoadTypes()
        {
            var types = Enum.GetValues(typeof(HarvestType));

            TypeComboBox.DataSource = types;

            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LoadCycles()
        {
            var cycles = Enum.GetValues(typeof(CultureCycle));

            CycleComboBox.DataSource = cycles;

            CycleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ClearCultureInfos()
        {
            CultureName.Text = string.Empty;
            TypeComboBox.Text = string.Empty;
            CycleComboBox.Text = string.Empty;
            PlantingDate.Text = string.Empty;
            EstimatedHarvestDate.Text = string.Empty;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Culture = null;
            CultureControl.GetInstance().SetContentPanelControl(CultureListControl.GetInstance());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var updateCultureDto = new Culture
            {
                Id = Culture.Id,
                Name = CultureName.Text,
                Type = (HarvestType)TypeComboBox.SelectedValue,
                Cycle = (CultureCycle)CycleComboBox.SelectedValue,
                PlantingDate = DateTime.Parse(PlantingDate.Text),
                EstimatedHarvestDate = DateTime.Parse(EstimatedHarvestDate.Text),
                FarmId = Culture.FarmId,
                ProductId = Culture.ProductId,
            };

            await CultureService.GetInstance().Update(updateCultureDto);

            CultureControl.GetInstance().SetContentPanelControl(CultureListControl.GetInstance());
        }
    }
}
