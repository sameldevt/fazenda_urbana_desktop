﻿using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
using fazenda_verdeviva.UserControls.Dashboard.Clients;
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
    public partial class EmployeeListControl : UserControl
    {
        private static EmployeeListControl? Instance;
        private EmployeeListControl()
        {
            InitializeComponent();
            EmployeesList.AutoScroll = true;
            LoadEmployeesCards();
        }

        public static EmployeeListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EmployeeListControl();
            }

            return Instance;
        }

        public async void LoadEmployeesCards()
        {
            List<Employee> employees = await EmployeeService.GetAll();

            employees.ForEach(async e =>
            {
                EmployeeCardControl employeeCard = new EmployeeCardControl();

                employeeCard.LoadCardInfo(e);
                EmployeesList.Controls.Add(employeeCard);
            });
        }
    }
}