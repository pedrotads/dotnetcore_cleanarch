namespace clientes.gateways.model
{
  public class EnderecoModel
  {
      public int Id { get;  set; }
      public string Logradouro { get; set; }
      public string Numero { get; set; }
      public string Cidade { get; set; }
      public string CEP { get; set; }
      public TipoEnderecoModel Tipo { get; set; }
  }
}