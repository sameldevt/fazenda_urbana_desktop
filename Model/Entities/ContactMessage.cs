using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class ContactMessage : EntityInterface
    {
        [JsonProperty("nomeUsuario")]
        public string UserName { get; set; }

        [JsonProperty("emailUsuario")]
        public string UserEmail { get; set; }

        [JsonProperty("conteudo")]
        public string Content { get; set; }

        [JsonProperty("dataEnvio")]
        public DateTime Date { get; set; }
    }
}
