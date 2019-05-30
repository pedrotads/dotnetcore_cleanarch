using System.Collections.Generic;
using clientes.domain;

namespace clientes.usecases
{
    public interface IListaClientesRepository
    {
        IList<Cliente> ListarClientes();
    } 
}