using System.Collections.Generic;
using clientes.domain;

namespace clientes.usecases
{
    public interface IListaClientes
    {
         IList<Cliente> Listar();
    }
}