using fazenda_verdeviva.Model.Dto;
using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Common;
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
    public partial class RegisterFarmControl : UserControl
    {
        private static RegisterFarmControl Instance;

        private List<Employee> Employees = new List<Employee>();
        private List<Equipment> Equipments = new List<Equipment>();
        private List<Harvest> Harvests = new List<Harvest>();

        private List<Employee>? DbEmployees;
        private List<Equipment>? DbEquipments;
        private List<Harvest>? DbHarvests;

        public RegisterFarmControl()
        {
            InitializeComponent();
        }

        public static RegisterFarmControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RegisterFarmControl();
            }

            Instance.LoadEmployees();
            Instance.LoadEquipments();
            Instance.LoadIsActive();
            return Instance;
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

            if (DbEmployees != null && DbEmployees.Any())
            {
                foreach (var e in DbEmployees)
                {
                    EmployeeCheckedList.Items.Add(e);
                }
            }
        }

        private async void LoadEquipments()
        {
            DbEquipments = await EquipmentService.GetInstance().GetAll();

            if (DbEquipments != null && DbEquipments.Any())
            {
                foreach (var e in DbEquipments)
                {
                    EquipmentsCheckedList.Items.Add(e);
                }
            }
        }

        private void ClearFarmInfos()
        {
            FarmName.Text = string.Empty;
            LocationTextBox.Text = string.Empty;
            FoundationDate.Text = string.Empty;
            NumberOfGreenhouses.Text = string.Empty;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Instance.ClearFarmInfos();
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
    }
}
