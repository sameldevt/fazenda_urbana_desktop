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

namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    public partial class EditEquipmentControl : UserControl
    {
        private static EditEquipmentControl? Instance;
        private Equipment Equipment;

        private EditEquipmentControl()
        {
            InitializeComponent();
        }

        public static EditEquipmentControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditEquipmentControl();
            }

            Instance.LoadEquipmentTypes();
            return Instance;
        }

        private void LoadEquipmentTypes()
        {
            var types = Enum.GetValues(typeof(EquipmentType));

            TypeComboBox.DataSource = null;
            TypeComboBox.Items.Clear();

            foreach (var type in types)
            {
                TypeComboBox.Items.Add(type.ToString());
            }

            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private async void LoadFarms()
        {
            var farms = await FarmService.GetInstance().GetAll();

            if (farms != null && farms.Any())
            {
                SupplierComboBox.DisplayMember = "Name";
                SupplierComboBox.ValueMember = "Id";
                SupplierComboBox.DataSource = farms;

                SupplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void ClearEquipmentInfos()
        {
            EquipmentName.Text = string.Empty;
            EquipmentDescription.Text = string.Empty;
            EquipmentBrand.Text = string.Empty;
            EquipmentModel.Text = string.Empty;
            PurchaseDate.Value = DateTime.MinValue;
            ImageUrl.Text = string.Empty;
            ManufacturingYear.Text = string.Empty;
            AcquisitionValue.Text = string.Empty;
            EquipmentImage = null;
        }

        private void LoadEquipmentImage(object sender, EventArgs e)
        {
            LoadEquipmentImage();
        }

        private async Task LoadEquipmentImage()
        {
            using HttpClient client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                byte[] imageData = await client.GetByteArrayAsync(ImageUrl.Text);

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

        public void LoadEquipmentInfo(Equipment equipment)
        {
            Equipment = equipment;

            equipment.Name = EquipmentName.Text;
            equipment.Description = EquipmentDescription.Text;
            equipment.ImageUrl = ImageUrl.Text;
            equipment.Type = (EquipmentType)Enum.Parse(typeof(EquipmentType), TypeComboBox.SelectedValue.ToString());
            equipment.Brand = EquipmentBrand.Text;
            equipment.Model = EquipmentModel.Text;
            equipment.PurchaseDate = PurchaseDate.Value;
            equipment.ManufactureYear = ManufacturingYear.Text;
            equipment.AcquisitionValue = decimal.Parse(AcquisitionValue.Text);

            LoadEquipmentImage();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var farm = await FarmService.GetInstance().GetById((int)LocationComboBox.SelectedValue);
            var supplier = await SupplierService.GetInstance().GetById(((int)SupplierComboBox.SelectedValue));

            Equipment.Name = EquipmentName.Text;
            Equipment.Description = EquipmentDescription.Text;
            Equipment.ImageUrl = ImageUrl.Text;
            Equipment.Type = (EquipmentType)Enum.Parse(typeof(EquipmentType), TypeComboBox.SelectedValue.ToString());
            Equipment.Brand = EquipmentBrand.Text;
            Equipment.Model = EquipmentModel.Text;
            Equipment.PurchaseDate = PurchaseDate.Value;
            Equipment.ManufactureYear = ManufacturingYear.Text;
            Equipment.AcquisitionValue = decimal.Parse(AcquisitionValue.Text);
            Equipment.CurrentLocation = farm.Name;
            Equipment.SupplierId = supplier.Id;

            await EquipmentService.GetInstance().Update(Equipment);

            EquipmentControl.GetInstance().SetContentPanelControl(EquipmentListControl.GetInstance());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EquipmentControl.GetInstance().SetContentPanelControl(EquipmentListControl.GetInstance());
        }
    }

}
