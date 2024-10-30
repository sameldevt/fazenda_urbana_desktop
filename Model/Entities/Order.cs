using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Order : EntityInterface
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cliente")]
        public virtual Client Client { get; set; }

        [JsonProperty("dataPedido")]
        public DateTime OrderDate { get; set; }

        [JsonProperty("dataEntrega")]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty("status")]
        public OrderStatus Status { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("enderecoEntrega")]
        public string DeliveryAddress { get; set; }

        [JsonProperty("formaPagamento")]
        public string PaymentMethod { get; set; }

        [JsonProperty("itens")]
        public virtual ICollection<OrderItem> Items { get; set; } = new HashSet<OrderItem>();

        public Order() { }
    }

    public class OrderItem
    {

        [JsonProperty("produtoId")]
        public virtual int ProductId { get; set; }

        [JsonProperty("quantidade")]
        public int Quantity { get; set; }

        [JsonProperty("subTotal")]
        public decimal SubTotal { get; init; }

        public OrderItem() { }
    }
}
