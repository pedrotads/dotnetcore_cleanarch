using System.Collections.Generic;
using clientes.domain;

namespace clientes.usecases
{
    public interface INovoCliente
    {
         Cliente Novo(Cliente cliente);
    }
}