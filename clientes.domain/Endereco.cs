using System;
using clientes.domain;

namespace clientes.domain
{  
  public class Endereco
  {
      public string Logradouro { get; set; }
      public string Numero { get; set; }
      public string Cidade { get; set; }
      public string CEP { get; set; }
      public TipoEndereco Tipo { get; set; }
  }
}