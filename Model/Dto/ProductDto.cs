using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Dto
{  
    public record RegisterProductDto
    {
        [JsonProperty("nome")]
        public string Name { get; init; }

        [JsonProperty("descricao")]
        public string Description { get; init; }

        [JsonProperty("precoQuilo")]
        public decimal WeightPrice { get; init; }

        [JsonProperty("quantidadeEstoque")]
        public int StockQuantity { get; init; }

        [JsonProperty("imagemUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("nutrientes")]
        public NutritionalInfoDto NutritionalInfo { get; set; }

        [JsonProperty("categoriaId")]
        public int CategoryId { get; init; }

        [JsonProperty("fornecedorId")]
        public int SupplierId { get; set; }
    }

    public record RegisterCategoryDto
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }
    }

    public record NutritionalInfoDto
    {
        [JsonProperty("calorias")]
        public decimal Calories { get; set; }

        [JsonProperty("proteinas")]
        public decimal Proteins { get; set; }

        [JsonProperty("carboidratos")]
        public decimal Carbohydrates { get; set; }

        [JsonProperty("fibras")]
        public decimal Fibers { get; set; }

        [JsonProperty("gorduras")]
        public decimal Fats { get; set; }
    }
}
