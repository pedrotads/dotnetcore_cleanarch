using System;
using System.Collections.Generic;
using System.Linq;
using clientes.domain;
using clientes.gateways.model;
using clientes.usecases;
using Mapster;

namespace clientes.gateways
{
    public class NovoClienteRepository : BaseRepository, INovoClienteRepository
    {
        public Cliente Novo(Cliente cliente)
        {
            Cliente result = cliente = null;
            return result;
        }
    }
}
