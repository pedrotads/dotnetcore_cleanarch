namespace clientes.gateways.model
{
  public class EnderecoModel
  {
      public int Id { get;  set; }
      //public int IdCliente { get; set; }
      public string Logradouro { get; set; }
      public string Numero { get; set; }
      public string Cidade { get; set; }
      public string CEP { get; set; }
      public int Tipo { get; set; }
  }
}