using clientes.domain;

namespace clientes.usecases
{
    public interface INovoClienteRepository
    {
         Cliente Novo(Cliente cliente);
    }
}