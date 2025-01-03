﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Farm : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("localizacao")]
        public string Location { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("dataFundacao")]
        public DateTime FoundationDate { get; set; }

        [JsonProperty("funcionarios")]
        public ICollection<Employee> Employees { get; set; }

        [JsonProperty("equipamentos")]
        public ICollection<Equipment> Equipments { get; set; }

        [JsonProperty("culturas")]
        public ICollection<Culture> Cultures { get; set; }

        [JsonProperty("numeroEstufas")]
        public int GreenhousesCount { get; set; }

        [JsonProperty("ativo")]
        public bool IsActive { get; set; }
    }

    public class Harvest : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

        [JsonProperty("fazendaId")]
        public int FarmId { get; set; }
    }

    public class Culture : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("típo")]
        public HarvestType Type { get; set; }

        [JsonProperty("ciclo")]
        public CultureCycle Cycle { get; set; }

        [JsonProperty("dataPlantio")]
        public DateTime PlantingDate { get; set; }

        [JsonProperty("dataColheitaPrevista")]
        public DateTime EstimatedHarvestDate { get; set; }

        [JsonProperty("fazendaId")]
        public int FarmId { get; set; }

        [JsonProperty("produtoId")]
        public int ProductId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
