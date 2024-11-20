using fazenda_verdeviva.Model.Dto;
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
    public partial class RegisterHarvestControl : UserControl
    {
        private static RegisterHarvestControl Instance;
        private Harvest Harvest;

        public RegisterHarvestControl()
        {
            InitializeComponent();
        }

        public static RegisterHarvestControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterHarvestControl();
            }

            Instance.LoadProducts();
            Instance.LoadCultures();
            Instance.ClearHarvestInfo();
            return Instance;
        }

        private async void LoadProducts()
        {
            if (ProductComboBox.Items.Count == 0)
            {
                var products = await ProductService.GetInstance().GetAll();

                if (products != null && products.Any())
                {
                    ProductComboBox.DataSource = null;

                    ProductComboBox.DisplayMember = "Name";
                    ProductComboBox.ValueMember = "id";
                    ProductComboBox.DataSource = products;

                    ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
        }

        private async void LoadCultures()
        {
            if (CultureComboBox.Items.Count == 0)
            {
                var cultures = await CultureService.GetInstance().GetAll();

                if (cultures != null && cultures.Any())
                {
                    CultureComboBox.DataSource = null;

                    CultureComboBox.DisplayMember = "Name";
                    CultureComboBox.ValueMember = "id";
                    CultureComboBox.DataSource = cultures;

                    CultureComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
        }

        public void ClearHarvestInfo()
        {
            Harvest = null;

            HarvestedArea.Text = string.Empty;
            HarvestedQuantity.Text = string.Empty;

            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var harvest = new RegisterHarvestDto
            {
                StartDate = StartDate.Value,
                EndDate = EndDate.Value,
                HarvestedArea = decimal.Parse(HarvestedArea.Text),
                HarvestedQuantity = decimal.Parse(HarvestedQuantity.Text),
                ProductId = (int)ProductComboBox.SelectedValue,
                CultureId = (int)CultureComboBox.SelectedValue,
            };

            await ColheitaService.GetInstance().Register(harvest);

            HarvestControl.GetInstance().RegisterButton.Enabled = true;
            HarvestControl.GetInstance().SetContentPanelControl(HarvestListControl.GetInstance());

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HarvestControl.GetInstance().RegisterButton.Enabled = true;
            HarvestControl.GetInstance().SetContentPanelControl(HarvestListControl.GetInstance());
        }
    }
}
