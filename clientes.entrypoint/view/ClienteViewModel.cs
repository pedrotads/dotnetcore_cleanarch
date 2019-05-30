using System;
using System.Collections.Generic;

namespace clientes.entrypoint.view
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public IList<EnderecoViewModel> Enderecos { get; set; } 
    }
}