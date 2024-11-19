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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    public partial class RegisterCultureControl : UserControl
    {
        private static RegisterCultureControl? Instance;

        private RegisterCultureControl()
        {
            InitializeComponent();
        }

        public static RegisterCultureControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterCultureControl();
            }

            Instance.LoadProducts();
            Instance.LoadTypes();
            Instance.LoadCycles();
            Instance.LoadFarms();
            Instance.ClearCultureInfos();
            return Instance;
        }

        private async void LoadProducts()
        {
            var products = await ProductService.GetInstance().GetAll();

            if (products != null && products.Any())
            {
                ProductComboBox.DataSource = products;
                ProductComboBox.DisplayMember = "Name";
                ProductComboBox.ValueMember = "Id";

                ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private async void LoadFarms()
        {
            var farms = await FarmService.GetInstance().GetAll();

            if(farms != null && farms.Any())
            {
                FarmComboBox.DataSource = farms;
                FarmComboBox.DisplayMember = "Name";
                FarmComboBox.ValueMember = "Id";

                FarmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
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
            ClearCultureInfos();
            CultureControl.GetInstance().SetContentPanelControl(CultureListControl.GetInstance());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var culture = new RegisterCultureDto
            {
                Name = CultureName.Text,
                Type = (HarvestType)Enum.Parse(typeof(HarvestType), TypeComboBox.Text),
                Cycle = (CultureCycle)Enum.Parse(typeof(CultureCycle), CycleComboBox.Text),
                PlantingDate = PlantingDate.Value,
                EstimatedHarvestDate = EstimatedHarvestDate.Value,
                FarmId = (int)FarmComboBox.SelectedValue
            };

            await CultureService.GetInstance().Register(culture);

            ClearCultureInfos();

            CultureControl.GetInstance().RegisterButton.Enabled = true;
            CultureControl.GetInstance().SetContentPanelControl(CultureListControl.GetInstance());
        }
    }

}
