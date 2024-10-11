using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazenda_verdeviva.Model.Dto
{
    public record ClienteDto
    {
        public string Nome { get; init; }
        public string Senha { get; init; }
        public DateTime DataCadastro { get; set; }
        //public ContatoDto Contato { get; init; }
        //public IEnumerable<Endereco> Enderecos { get; init; }

        //public CadastrarClienteDto() { }
    }
}
