using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model
{
    public enum OrderStatus
    {
        ENTREGUE,
        EM_TRANSITO,
        PAGO,
        AGUARDANDO_PAGAMENTO,
    }

    public enum HarvestType
    {
        Fruits,
        Grains,
        Vegetables,
        Legumes
    }

    public enum CultureCycle
    {
        Short,
        Medium,
        Long
    }

    public enum EquipmentType
    {
        Irrigation,
        TemperatureControl,
        IndoorCultivation,
        Sowing,
        Harvesting,
        Storage,
        Composting,
        Monitoring,
        Transportation,
        GeneralGardening,
        HydroponicSystem,
        ProtectiveEquipment,
        Automation,
        Fertilization,
        PestControl
    }
}
