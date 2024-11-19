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

namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    public partial class EquipmentCardControl : UserControl
    {
        private Equipment? Equipment;

        public EquipmentCardControl()
        {
            InitializeComponent();
        }

        public async void LoadCardInfo(Equipment equipment)
        {
            Equipment = equipment;
            EquipmentName.Text = equipment.Name;
            EquipmentDescription.Text = equipment.Description;
            EquipmentBrand.Text = equipment.Brand;
            EquipmentType.Text = equipment.Type.ToString();

            var supplier = await SupplierService.GetInstance().GetById(equipment.SupplierId);

            EquipmentSupplier.Text = supplier.Name;

            await LoadEquipmentImage(equipment);
        }

        private async Task LoadEquipmentImage(Equipment equipment)
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(equipment.ImageUrl);

                try
                {
                    using MemoryStream ms = new MemoryStream(imageData);
                    EquipmentImage.Image = Image.FromStream(ms);
                }
                catch (ArgumentException)
                {
                    using SKBitmap bitmap = SKBitmap.Decode(imageData);

                    using SKImage image = SKImage.FromBitmap(bitmap);
                    using SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100);

                    using MemoryStream ms = new MemoryStream(data.ToArray());
                    EquipmentImage.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                EquipmentImage.Image = Image.FromFile("Assets/image-not-found.png");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editEquipmentControlInstance = EditEquipmentControl.GetInstance();
            editEquipmentControlInstance.LoadEquipmentInfo(Equipment);
            EquipmentControl.GetInstance().SetContentPanelControl(editEquipmentControlInstance);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await EquipmentService.GetInstance().Delete(Equipment!.Id);
            EquipmentListControl.GetInstance().EquipmentList.Controls.Remove(this);
        }
    }
}
