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

            Instance.LoadTypes();
            Instance.LoadCycles();
            Instance.ClearCultureInfos();
            return Instance;
        }

        public void LoadTypes()
        {
            var types = Enum.GetValues(typeof(HarvestType));

            TypeComboBox.DataSource = null;
            TypeComboBox.Items.Clear();

            foreach (var type in types)
            {
                TypeComboBox.Items.Add(type.ToString());
            }

            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LoadCycles()
        {
            var types = Enum.GetValues(typeof(CultureCycle));

            CycleComboBox.DataSource = null;
            CycleComboBox.Items.Clear();

            foreach (var type in types)
            {
                CycleComboBox.Items.Add(type.ToString());
            }

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
                Type = (HarvestType)Enum.Parse(typeof(HarvestType), TypeComboBox.SelectedText),
                Cycle = (CultureCycle)Enum.Parse(typeof(CultureCycle), CycleComboBox.SelectedText),
                PlantingDate = DateTime.Parse(PlantingDate.Text),
                EstimatedHarvestDate = DateTime.Parse(EstimatedHarvestDate.Text)
            };

            await CultureService.GetInstance().Register(culture);

            ClearCultureInfos();

            CultureControl.GetInstance().SetContentPanelControl(CultureListControl.GetInstance());

        }
    }

}
