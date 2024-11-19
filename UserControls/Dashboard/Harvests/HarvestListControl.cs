using fazenda_verdeviva.Model;
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

namespace fazenda_verdeviva.UserControls.Dashboard.Harvests
{
    public partial class HarvestListControl : UserControl
    {
        private static HarvestListControl? Instance;

        private HarvestListControl()
        {
            InitializeComponent();
            HarvestsList.AutoScroll = true;
        }

        public static HarvestListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new HarvestListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            HarvestsList.Controls.Clear();

            List<Harvest> harvests = await ColheitaService.GetInstance().GetAll();

            try
            {
                harvests.ForEach(async h =>
                {
                    HarvestCardControl harvestCard = new HarvestCardControl();
                    harvestCard.LoadCardInfo(h);
                    HarvestsList.Controls.Add(harvestCard);
                });
            }
            catch (Exception ex)
            {
                HarvestControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }

}
