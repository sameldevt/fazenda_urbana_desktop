using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Supplier : User, EntityInterface
    {
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
        
        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("insumos")]
        public virtual ICollection<Supply> Insumos { get; set; }

        [JsonProperty("equipamentos")]
        public virtual ICollection<Equipment> Equipamentos { get; set; }

    }

    public class Supply : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }

        [JsonProperty("imagemUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("categoria")]
        public string Category { get; set; }

        [JsonProperty("quantidadeEstoque")]
        public decimal StockQuantity { get; set; }

        [JsonProperty("precoUnitario")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("dataCompra")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("dataFabricacao")]
        public DateTime ManufactureDate { get; set; }

        [JsonProperty("dataVencimento")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("fornecedorId")]
        public int SupplierId { get; set; }
    }

    public class Equipment : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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
        public string ManufactureYear { get; set; }

        [JsonProperty("valorAquisicao")]
        public decimal AcquisitionValue { get; set; }

        [JsonProperty("localizacaoAtual")]
        public string CurrentLocation { get; set; }

        [JsonProperty("fornecedorId")]
        public int SupplierId { get; set; }

        [JsonProperty("fazendaId")]
        public int FarmId { get; set; }
    }
}
