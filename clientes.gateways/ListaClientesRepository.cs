﻿using System;
using System.Collections.Generic;
using System.Linq;
using clientes.domain;
using clientes.usecases;
using Mapster;

namespace clientes.gateways
{
    public class ListaClientesRepository : BaseRepository, IListaClientesRepository
    {
        public IList<Cliente> ListarClientes()
        {
            List<Cliente> result = null;
            return result;
        }
    }
}
