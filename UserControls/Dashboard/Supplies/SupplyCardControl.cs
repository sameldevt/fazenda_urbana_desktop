using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Equipments;
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
    public partial class SupplyCardControl : UserControl
    {
        private Supply? Supply;

        public SupplyCardControl()
        {
            InitializeComponent();
        }

        public async void LoadCardInfo(Supply supply)
        {
            this.Supply = supply;
            SupplyName.Text = supply.Name;
            SupplyDescription.Text = supply.Description;
            SupplyCategory.Text = supply.Category;
            StockQuantity.Text = supply.StockQuantity.ToString();
            UnitPrice.Text = supply.UnitPrice.ToString();

            var supplier = await SupplierService.GetInstance().GetById(supply.SupplierId);
            SupplySupplier.Text = supplier.Name;

            LoadSupplyImage(supply);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editSupplyControlInstance = EditSupplyControl.GetInstance();
            editSupplyControlInstance.LoadSupplyInfo(Supply);
            SupplyControl.GetInstance().SetContentPanelControl(editSupplyControlInstance);
        }

        private async Task LoadSupplyImage(Supply supply)
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(supply.ImageUrl);

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

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Supply != null)
            {
                await SupplyService.GetInstance().Delete(Supply.Id);
                SupplyListControl.GetInstance().SupplyList.Controls.Remove(this);
            }
        }

        private void SupplyDetails_Click(object sender, EventArgs e)
        {
            var supplyDetailsControlInstance = EditSupplyControl.GetInstance();
            supplyDetailsControlInstance.LoadSupplyInfo(Supply);
            SupplyControl.GetInstance().SetContentPanelControl(supplyDetailsControlInstance);
        }
    }
}
