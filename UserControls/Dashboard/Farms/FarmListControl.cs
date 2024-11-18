using fazenda_verdeviva.Model.Entities;
using fazenda_verdeviva.Services;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    public partial class FarmListControl : UserControl, ControlInterface
    {
        private static FarmListControl? Instance;

        private FarmListControl()
        {
            InitializeComponent();
            FarmList.AutoScroll = true;
        }

        public static FarmListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new FarmListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            FarmList.Controls.Clear();

            List<Farm> farms = await FarmService.GetInstance().GetAll();

            try
            {
                farms.ForEach(async f =>
                {
                    FarmCardControl farmCard = new FarmCardControl();

                    farmCard.LoadCardInfo(f);
                    FarmList.Controls.Add(farmCard);
                });
            }
            catch (Exception ex)
            {
                FarmControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }

}
