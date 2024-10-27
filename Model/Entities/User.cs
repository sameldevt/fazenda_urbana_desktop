using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace fazenda_verdeviva.Model.Entities
{
    public class User
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("dataCadastro")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("contato")]
        public virtual Contact Contact { get; set; }

        [JsonProperty("enderecos")]
        public virtual ICollection<Address> Addresses { get; set; }
    }

    public class Contact
    {
        [JsonProperty("telefone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Address
    {
        [JsonProperty("logradouro")]
        public string Street { get; set; }

        [JsonProperty("numero")]
        public string Number { get; set; }

        [JsonProperty("cidade")]
        public string City { get; set; }

        [JsonProperty("cep")]
        public string PostalCode { get; set; }

        [JsonProperty("complemento")]
        public string Complement { get; set; }

        [JsonProperty("estado")]
        public string State { get; set; }

        [JsonProperty("informacoesAdicionais")]
        public string AdditionalInfo { get; set; }
    }
}
