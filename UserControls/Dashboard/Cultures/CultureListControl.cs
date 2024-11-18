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

namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    public partial class CultureListControl : UserControl, ControlInterface
    {
        private static CultureListControl? Instance;

        private CultureListControl()
        {
            InitializeComponent();
            CultureList.AutoScroll = true;
        }

        public static CultureListControl GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CultureListControl();
            }

            Instance.LoadCards();
            return Instance;
        }

        public async Task LoadCards()
        {
            CultureList.Controls.Clear();

            List<Culture> cultures = await CultureService.GetInstance().GetAll();

            try
            {
                cultures.ForEach(async c =>
                {
                    CultureCardControl cultureCard = new CultureCardControl();

                    await cultureCard.LoadCardInfo(c);
                    CultureList.Controls.Add(cultureCard);
                });
            }
            catch (Exception ex)
            {
                CultureControl.GetInstance().SetContentPanelControl(NoResourceFound.GetInstance());
            }
        }
    }

}
