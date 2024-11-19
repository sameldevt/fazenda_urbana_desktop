using fazenda_verdeviva.Model;
using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Supplies
{
    public partial class RegisterSupplyControl : UserControl
    {
        private static RegisterSupplyControl Instance;
        private Supply Supply = new Supply();

        public RegisterSupplyControl()
        {
            InitializeComponent();
        }

        public static RegisterSupplyControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterSupplyControl();
            }

            Instance.LoadSuppliers();
            Instance.LoadCategories();
            Instance.ClearSupplyInfos();
            return Instance;
        }

        private void ClearSupplyInfos()
        {
            SupplyName.Text = string.Empty;
            SupplyDescription.Text = string.Empty;
            StockQuantity.Text = string.Empty;
            UnitPrice.Text = string.Empty;
            ImageUrl.Text = string.Empty;
            PurchaseDate.Text = string.Empty;
            ManufacturingDate.Text = string.Empty;
            ExpirationDate.Text = string.Empty;

            SupplyImage.Image = null;
        }

        private void LoadCategories()
        {
            var categories = Enum.GetValues(typeof(SupplyCategory));

            CategoryComboBox.DataSource = categories;

            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void LoadSuppliers()
        {
            var suppliers = await SupplierService.GetInstance().GetAll();

            if (suppliers != null && suppliers.Any())
            {
                SupplierComboBox.DisplayMember = "Name";
                SupplierComboBox.ValueMember = "Id";
                SupplierComboBox.DataSource = suppliers;

                SupplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void LoadSupplyImage(object sender, EventArgs e)
        {
            LoadSupplyImage();
        }

        private async Task LoadSupplyImage()
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(ImageUrl.Text);

                try
                {
                    using MemoryStream ms = new MemoryStream(imageData);
                    SupplyImage.Image = Image.FromStream(ms);
                }
                catch (ArgumentException)
                {
                    using SKBitmap bitmap = SKBitmap.Decode(imageData);

                    using SKImage image = SKImage.FromBitmap(bitmap);
                    using SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100);

                    using MemoryStream ms = new MemoryStream(data.ToArray());
                    SupplyImage.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                SupplyImage.Image = Image.FromFile("Assets/image-not-found.png");
            }
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var supply = new RegisterSupplyDto
            {
                Name = SupplyName.Text,
                Description = SupplyDescription.Text,
                Category = CategoryComboBox.Text,
                ImageUrl = ImageUrl.Text,
                StockQuantity = decimal.Parse(StockQuantity.Text),
                UnitPrice = decimal.Parse(UnitPrice.Text),
                PurchaseDate = PurchaseDate.Value,
                ManufacturingDate = ManufacturingDate.Value,
                ExpirationDate = ExpirationDate.Value,
                SupplierId = (int)SupplierComboBox.SelectedValue
            };

            await SupplyService.GetInstance().Register(supply);

            SupplyControl.GetInstance().RegisterButton.Enabled = true;
            SupplyControl.GetInstance().SetContentPanelControl(SupplyListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SupplyControl.GetInstance().RegisterButton.Enabled = true;
            SupplyControl.GetInstance().SetContentPanelControl(SupplyListControl.GetInstance());
        }
    }

}
