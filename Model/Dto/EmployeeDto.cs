using fazenda_verdeviva.Model.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Dto
{
    public record RegisterEmployeeDto
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("senha")]
        public string Password { get; set; }

        [JsonProperty("cargo")]
        public string Position { get; init; } 

        [JsonProperty("numeroRegistro")]
        public string RegistrationNumber { get; init; } 

        [JsonProperty("dataCadastro")]
        public DateTime RegistrationDate { get; init; } 

        [JsonProperty("contato")]
        public Contact Contact { get; init; }

        [JsonProperty("enderecos")]
        public IEnumerable<Address> Addresses { get; init; }
    }
}
