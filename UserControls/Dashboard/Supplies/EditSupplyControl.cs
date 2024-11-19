using fazenda_verdeviva.Model;
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
    public partial class EditSupplyControl : UserControl
    {
        private static EditSupplyControl Instance;
        private Supply Supply;

        private EditSupplyControl()
        {
            InitializeComponent();
        }

        public static EditSupplyControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditSupplyControl();
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

        private void LoadCategories()
        {
            var categories = Enum.GetValues(typeof(SupplyCategory));

            CategoryComboBox.DataSource = categories;

            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public void LoadSupplyInfo(Supply supply)
        {
            Supply = supply;

            SupplyName.Text = supply.Name;
            SupplyDescription.Text = supply.Description;
            StockQuantity.Text = supply.StockQuantity.ToString();
            UnitPrice.Text = supply.UnitPrice.ToString();
            ImageUrl.Text = supply.ImageUrl;
            PurchaseDate.Value = supply.PurchaseDate;
            ManufacturingDate.Value = supply.ManufactureDate;
            ExpirationDate.Value = supply.ExpirationDate;

            CategoryComboBox.SelectedText = supply.Category;

            LoadSupplyImage();
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
            Supply.Name = SupplyName.Text;
            Supply.Description = SupplyDescription.Text;
            Supply.Category = CategoryComboBox.Text;
            Supply.ImageUrl = ImageUrl.Text;
            Supply.StockQuantity = decimal.Parse(StockQuantity.Text);
            Supply.UnitPrice = decimal.Parse(UnitPrice.Text);
            Supply.PurchaseDate = PurchaseDate.Value;
            Supply.ManufactureDate = ManufacturingDate.Value;
            Supply.ExpirationDate = ExpirationDate.Value;
            Supply.SupplierId = (int)SupplierComboBox.SelectedValue;

            await SupplyService.GetInstance().Update(Supply);

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
