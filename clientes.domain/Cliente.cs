using System;
using System.Collections.Generic;

namespace clientes.domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public IList<Endereco> Enderecos { get; set; }
    }
}
