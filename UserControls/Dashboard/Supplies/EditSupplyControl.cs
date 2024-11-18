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

            Instance.LoadCategories();
            return Instance;
        }

        private void LoadCategories()
        {
            var categories = Enum.GetValues(typeof(SupplyCategory));

            CategoryComboBox.DataSource = null;
            CategoryComboBox.Items.Clear();

            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category.ToString());
            }

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

        private async void SaveButton_Click(object sender, EventArgs e)
        {

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
