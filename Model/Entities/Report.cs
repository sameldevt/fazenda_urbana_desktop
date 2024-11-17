using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Entities
{
    public class Report : EntityInterface
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tipoRelatorio")]
        public string ReportType { get; set; }

        [JsonProperty("periodoInicio")]
        public DateTime StartingPeriod { get; set; }

        [JsonProperty("periodoFim")]
        public DateTime EndingPeriod { get; set; }

        [JsonProperty("mensagem")]
        public string Message { get; set; } 
    }
}
