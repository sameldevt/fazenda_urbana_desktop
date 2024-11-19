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
        private List<Culture> Cultures = new List<Culture>();

        private List<Employee>? DbEmployees;
        private List<Equipment>? DbEquipments;
        private List<Culture>? DbCultures;

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

            Instance.LoadIsActive();
            Instance.LoadEmployees();
            Instance.LoadEquipments();
            Instance.LoadCultures();
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
            IsActiveComboBox.Text = farm.IsActive ? "Sim" : "Não";
            Employees.AddRange(farm.Employees);
            Equipments.AddRange(farm.Equipments);
            Cultures.AddRange(farm.Cultures);
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

            if (DbEmployees != null && DbEmployees.Count > 0)
            {
                foreach (var e in DbEmployees)
                {
                    EmployeeCheckedList.Items.Add(e);

                    bool isChecked = true;

                    int index = EmployeeCheckedList.Items.IndexOf(e);
                    if (index != -1)
                    {
                        EmployeeCheckedList.SetItemChecked(index, isChecked);
                    }
                }
            }
        }


        private async void LoadEquipments()
        {
            DbEquipments = await EquipmentService.GetInstance().GetAll();

            if (DbEquipments != null && DbEquipments.Count > 0)
            {
                foreach (var e in DbEquipments)
                {
                    EquipmentsCheckedList.Items.Add(e);

                    int index = EquipmentsCheckedList.Items.IndexOf(e);
                    if (index != -1)
                    {
                        EquipmentsCheckedList.SetItemChecked(index, true);
                    }
                }
            }
        }

        private async void LoadCultures()
        {
            DbCultures = await CultureService.GetInstance().GetAll();

            if (DbCultures != null && DbCultures.Count > 0)
            {
                foreach (var h in DbCultures)
                {
                    CulturesCheckedList.Items.Add(h);

                    int index = CulturesCheckedList.Items.IndexOf(h);
                    if (index != -1)
                    {
                        CulturesCheckedList.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void ClearFarmInfos()
        {
            FarmName.Text = string.Empty;
            LocationTextBox.Text = string.Empty;
            FoundationDate.Text = string.Empty;
            NumberOfGreenhouses.Text = string.Empty;
            Employees.Clear();
            Equipments.Clear();
            Cultures.Clear();
            DbCultures?.Clear();
            DbEmployees?.Clear();
            DbEquipments?.Clear();
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

        private void CulturesCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (CulturesCheckedList.Items[index] is Culture culture)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!Cultures.Contains(culture))
                    {
                        Cultures.Add(culture);
                    }
                }
                else
                {
                    if (Cultures.Contains(culture))
                    {
                        Cultures.Remove(culture);
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FarmControl.GetInstance().RegisterButton.Enabled = true;
            FarmControl.GetInstance().SetContentPanelControl(FarmListControl.GetInstance());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Farm.Name = FarmName.Text;
            Farm.Location = LocationTextBox.Text;
            Farm.Area = double.Parse(AreaTextBox.Text);
            Farm.FoundationDate = FoundationDate.Value;

            var tasks = Employees.Select(async e =>
            {
                return await EmployeeService.GetInstance().GetById(e.Id);
            });

            Farm.Employees = await Task.WhenAll(tasks);

            var equipmentTasks = Equipments.Select(async e =>
            {
                return await EquipmentService.GetInstance().GetById(e.Id);
            });

            Farm.Equipments = await Task.WhenAll(equipmentTasks);

            var cultureTasks = Cultures.Select(async e =>
            {
                return await CultureService.GetInstance().GetById(e.Id);
            });

            Farm.Cultures = await Task.WhenAll(cultureTasks);

            Farm.GreenhousesCount = int.Parse(NumberOfGreenhouses.Text);
            Farm.IsActive = IsActiveComboBox.SelectedValue.Equals("Sim");

            await FarmService.GetInstance().Update(Farm);

            FarmControl.GetInstance().RegisterButton.Enabled = true;
            FarmControl.GetInstance().SetContentPanelControl(FarmListControl.GetInstance());
        }
    }
}
