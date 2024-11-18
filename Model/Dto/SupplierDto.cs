using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Dto
{
    internal record RegisterSupplierDto
    {
        [JsonProperty("nome")]
        public string Name { get; init; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; init; }

        [JsonProperty("website")]
        public string Website { get; init; }

        [JsonProperty("dataCadastro")]
        public DateTime RegistrationDate { get; init; } = DateTime.Now;

        [JsonProperty("contato")]
        public Contact Contact { get; init; }

        [JsonProperty("enderecos")]
        public IEnumerable<Address> Addresses { get; init; }
    }

    public record RegisterEquipmentDto 
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }

        [JsonProperty("imagemUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("tipo")]
        public EquipmentType Type { get; set; }

        [JsonProperty("marca")]
        public string Brand { get; set; }

        [JsonProperty("modelo")]
        public string Model { get; set; }

        [JsonProperty("dataCompra")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("anoFabricacao")]
        public string ManufacturingYear { get; set; }

        [JsonProperty("valorAquisicao")]
        public decimal AcquisitionValue { get; set; }

        [JsonProperty("localizacaoAtual")]
        public string CurrentLocation { get; set; }

        [JsonProperty("fornecedorId")]
        public int SupplierId { get; set; }
    }

    public record RegisterSupplyDto 
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }

        [JsonProperty("categoria")]
        public string Category { get; set; }

        [JsonProperty("imagemUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("quantidadeEstoque")]
        public decimal StockQuantity { get; set; }

        [JsonProperty("precoUnitario")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("dataCompra")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("dataFabricacao")]
        public DateTime ManufacturingDate { get; set; }

        [JsonProperty("dataVencimento")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("fornecedorId")]
        public int SupplierId { get; set; }
    }
}
