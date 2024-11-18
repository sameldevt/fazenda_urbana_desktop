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

namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    public partial class EditFarmControl : UserControl
    {
        private static EditFarmControl Instance;
        private Farm? Farm;

        private List<Employee> Employees = new List<Employee>();
        private List<Equipment> Equipments = new List<Equipment>();
        private List<Harvest> Harvests = new List<Harvest>();

        private List<Employee>? DbEmployees;
        private List<Equipment>? DbEquipments;
        private List<Harvest>? DbHarvests;

        private EditFarmControl()
        {
            InitializeComponent();
        }

        public static EditFarmControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EditFarmControl();
            }

            Instance.LoadEmployees();
            Instance.LoadEquipments();
            Instance.LoadHarvests();
            Instance.ClearFarmInfos();
            return Instance;
        }

        public void LoadFarmInfos(Farm farm)
        {
            this.Farm = farm;

            FarmName.Text = farm.Name;
            LocationTextBox.Text = farm.Location;
            FoundationDate.Value = farm.FoundationDate;
            NumberOfGreenhouses.Text = farm.GreenhousesCount.ToString();
            AreaTextBox.Text = farm.Area.ToString("F2");
            IsActiveComboBox.SelectedValue = farm.IsActive ? "Sim" : "Não";
            Employees = farm.Employees.ToList();
            Equipments = farm.Equipments.ToList();
            Harvests = farm.Harvests.ToList();

        }

        private void LoadIsActive()
        {
            var options = new List<string>
            {
                "Sim",
                "Não"
            };

            IsActiveComboBox.DataSource = options;
            IsActiveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void LoadEmployees()
        {
            DbEmployees = await EmployeeService.GetInstance().GetAll();

            foreach (var e in DbEmployees)
            {
                EmployeeCheckedList.Items.Add(e);
            }

            
        }

        private async void LoadEquipments()
        {
            DbEquipments = await EquipmentService.GetInstance().GetAll();

            foreach (var e in DbEquipments)
            {
                EquipmentsCheckedList.Items.Add(e);
            }
        }

        private async void LoadHarvests()
        {
            DbHarvests = await HarvestService.GetInstance().GetAll();

            foreach (var h in DbHarvests)
            {
                HarvestsCheckedList.Items.Add(h);
            }
        }

        private void ClearFarmInfos()
        {
            FarmName.Text = string.Empty;
            LocationTextBox.Text = string.Empty;
            FoundationDate.Text = string.Empty;
            NumberOfGreenhouses.Text = string.Empty;
            EmployeeCheckedList.SelectedIndex = 0;
            EquipmentsCheckedList.SelectedIndex = 0;
            HarvestsCheckedList.SelectedIndex = 0;
            IsActiveComboBox.SelectedIndex = 0;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FarmControl.GetInstance().RegisterButton.Enabled = true;
            FarmControl.GetInstance().SetContentPanelControl(FarmListControl.GetInstance());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var farm = new RegisterFarmDto
            {
                Name = FarmName.Text,
                Location = LocationTextBox.Text,
                Area = double.Parse(AreaTextBox.Text),
                FoundationDate = FoundationDate.Value,
                EmployeeIds = Employees.Select(e => e.Id).ToArray(),
                EquipmentIds = Equipments.Select(e => e.Id).ToArray(),
                HarvestIds = Harvests.Select(e => e.Id).ToArray(),
                NumberOfGreenhouses = int.Parse(NumberOfGreenhouses.Text),
                IsActive = IsActiveComboBox.SelectedValue.Equals("Sim"),
            };

            await FarmService.GetInstance().Register(farm);

            FarmControl.GetInstance().RegisterButton.Enabled = true;
            FarmControl.GetInstance().SetContentPanelControl(FarmListControl.GetInstance());
        }

        private void EmployeeCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (EmployeeCheckedList.Items[index] is Employee employee)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!Employees.Contains(employee))
                    {
                        Employees.Add(employee);
                    }
                }
                else
                {
                    if (Employees.Contains(employee))
                    {
                        Employees.Remove(employee);
                    }
                }
            }
        }

        private void EquipmentsCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (EquipmentsCheckedList.Items[index] is Equipment equipment)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!Equipments.Contains(equipment))
                    {
                        Equipments.Add(equipment);
                    }
                }
                else
                {
                    if (Equipments.Contains(equipment))
                    {
                        Equipments.Remove(equipment);
                    }
                }
            }
        }

        private void HarvestsCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (HarvestsCheckedList.Items[index] is Harvest harvest)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!Harvests.Contains(harvest))
                    {
                        Harvests.Add(harvest);
                    }
                }
                else
                {
                    if (Harvests.Contains(harvest))
                    {
                        Harvests.Remove(harvest);
                    }
                }
            }
        }
    }
}
