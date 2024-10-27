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

}
