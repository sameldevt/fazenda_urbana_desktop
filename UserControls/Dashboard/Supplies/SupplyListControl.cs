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

namespace fazenda_verdeviva.UserControls.Dashboard.Supplies
{
    public partial class SupplyListControl : UserControl, ControlInterface
    {
        private static SupplyListControl? Instance;

        private SupplyListControl()
        {
            InitializeComponent();
            SupplyList.AutoScroll = true;
        }

        public static SupplyListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SupplyListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            SupplyList.Controls.Clear();

            List<Supply> supplies = await SupplyService.GetInstance().GetAll();

            try
            {
                foreach (var supply in supplies)
                {
                    SupplyCardControl supplyCard = new SupplyCardControl();

                    supplyCard.LoadCardInfo(supply);
                    SupplyList.Controls.Add(supplyCard);
                }
            }
            catch (Exception ex)
            {
                SupplyControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }

}
