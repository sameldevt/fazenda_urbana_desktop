using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Client : User, EntityInterface
    {
        [JsonProperty("senha")]
        public string Password { get; set; }

        [JsonProperty("pedidos")]
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
