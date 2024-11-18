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

namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    public partial class EquipmentListControl : UserControl
    {
        private static EquipmentListControl? Instance;

        private EquipmentListControl()
        {
            InitializeComponent();
            EquipmentList.AutoScroll = true;
        }

        public static EquipmentListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EquipmentListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            EquipmentList.Controls.Clear();

            List<Equipment> equipmentList = await EquipmentService.GetInstance().GetAll();

            try
            {
                equipmentList.ForEach(async e =>
                {
                    EquipmentCardControl equipmentCard = new EquipmentCardControl();
                    equipmentCard.LoadCardInfo(e);
                    EquipmentList.Controls.Add(equipmentCard);
                });
            }
            catch (Exception ex)
            {
                EquipmentControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }

}
