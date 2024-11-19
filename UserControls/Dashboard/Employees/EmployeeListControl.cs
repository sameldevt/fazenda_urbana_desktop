using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Clients;
using fazenda_verdeviva.UserControls.Dashboard.Common;
using fazenda_verdeviva.UserControls.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.UserControls.Dashboard.Employees
{
    public partial class EmployeeListControl : UserControl, ControlInterface
    {
        private static EmployeeListControl? Instance;
        private EmployeeListControl()
        {
            InitializeComponent();
            EmployeesList.AutoScroll = true;
        }

        public static EmployeeListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EmployeeListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {

            EmployeesList.Controls.Clear();

            List<Employee> employees = await EmployeeService.GetInstance().GetAll();

            try
            {
                employees.ForEach(async e =>
                {
                    EmployeeCardControl employeeCard = new EmployeeCardControl();

                    employeeCard.LoadCardInfo(e);
                    EmployeesList.Controls.Add(employeeCard);
                });
            }
            catch (Exception ex)
            {
                EmployeeControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }
}
