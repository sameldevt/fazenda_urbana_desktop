using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model
{
    public enum OrderStatus
    {
        Entregue,
        EmTransito,
        Pago,
        AguardandoPagamento,
    }

    public enum HarvestType
    {
        Frutas,
        Graos,
        Vegetais,
        Leguminosas
    }

    public enum CultureCycle
    {
        Curto,
        Medio,
        Longo
    }

    public enum EquipmentType
    {
        Irrigacao,
        ControleDeTemperatura,
        CultivoInterno,
        Semeadura,
        Colheita,
        Armazenamento,
        Compostagem,
        Monitoramento,
        Transporte,
        JardinagemGeral,
        SistemaHidroponico,
        EquipamentoDeProtecao,
        Automacao,
        Fertilizacao,
        ControleDePragas
    }

}
