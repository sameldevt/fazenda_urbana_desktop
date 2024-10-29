using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace fazenda_verdeviva.Model.Entities
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }

        [JsonProperty("precoQuilo")]
        public double WeightPrice { get; set; }

        [JsonProperty("quantidadeEstoque")]
        public int StockQuantity { get; set; }

        [JsonProperty("imagemUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("categoria")]
        public virtual Category Category { get; set; }

        [JsonProperty("nutrientes")]
        public virtual NutritionalInfo NutritionalInfo { get; set; }

        [JsonProperty("fornecedor")]
        public virtual Supplier Supplier { get; set; }
    }

    public class Category
    {

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("descricao")]
        public string Description { get; set; }
    }

    public class NutritionalInfo
    {
        [JsonProperty("calorias")]
        public double Calories { get; set; }

        [JsonProperty("proteinas")]
        public double Proteins { get; set; }

        [JsonProperty("carboidratos")]
        public double Carbohydrates { get; set; }

        [JsonProperty("fibras")]
        public double Fibers { get; set; }

        [JsonProperty("gorduras")]
        public double Fats { get; set; }
    }
}
