using System;
using System.Collections.Generic;

namespace clientes.gateways.model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        //public IList<EnderecoModel> Enderecos { get; set; }
    }

}