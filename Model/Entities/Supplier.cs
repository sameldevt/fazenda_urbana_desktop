using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Supplier : User
    {
        [JsonProperty("cpnj")]
        public string CNPJ { get; set; }
        
        [JsonProperty("website")]
        public string Website { get; set; }
    }
}
