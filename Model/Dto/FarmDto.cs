using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Dto
{
    public record RegisterHarvestDto
    {
        [JsonProperty("dataInicio")]
        public DateTime StartDate { get; set; }

        [JsonProperty("dataFim")]
        public DateTime EndDate { get; set; }

        [JsonProperty("areaColhida")]
        public decimal HarvestedArea { get; set; }

        [JsonProperty("quantidadeColhida")]
        public decimal HarvestedQuantity { get; set; }

        [JsonProperty("produtoId")]
        public int ProductId { get; set; }

        [JsonProperty("culturaId")]
        public int CultureId { get; set; }
    }

    public record RegisterFarmDto
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("localizacao")]
        public string Location { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("dataFundacao")]
        public DateTime FoundationDate { get; set; }

        [JsonProperty("funcionariosIds")]
        public ICollection<int> EmployeeIds { get; set; }

        [JsonProperty("equipamentosIds")]
        public ICollection<int> EquipmentIds { get; set; }

        [JsonProperty("colheitasIds")]
        public ICollection<int> HarvestIds { get; set; }

        [JsonProperty("numeroEstufas")]
        public int NumberOfGreenhouses { get; set; }

        [JsonProperty("ativo")]
        public bool IsActive { get; set; }
    }

    public record RegisterCultureDto
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("tipo")]
        public HarvestType Type { get; set; }

        [JsonProperty("ciclo")]
        public CultureCycle Cycle { get; set; }

        [JsonProperty("dataPlantio")]
        public DateTime PlantingDate { get; set; }

        [JsonProperty("dataColheitaPrevista")]
        public DateTime EstimatedHarvestDate { get; set; }

        [JsonProperty("fazendaId")]
        public int FarmId { get; set; }
    }
}
