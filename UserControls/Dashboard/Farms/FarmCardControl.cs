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
    public partial class FarmCardControl : UserControl
    {
        private Farm? Farm;

        public FarmCardControl()
        {
            InitializeComponent();
        }

        public void LoadCardInfo(Farm farm)
        {
            this.Farm = farm;
            FarmName.Text = farm.Name;
            Location.Text = farm.Location;
            Area.Text = farm.Area.ToString("F2");
            GreenhousesCount.Text = farm.GreenhousesCount.ToString();
            IsActive.Text = farm.IsActive ? "Sim" : "Não";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editFarmControlInstance = EditFarmControl.GetInstance();
            editFarmControlInstance.LoadFarmInfos(Farm);
            FarmControl.GetInstance().SetContentPanelControl(editFarmControlInstance);

        }
    }
}
