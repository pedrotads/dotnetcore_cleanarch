using System;
using System.Collections.Generic;
using System.Linq;
using clientes.domain;
using clientes.gateways.dbcontext;
using clientes.usecases;
using Mapster;

namespace clientes.gateways
{
    public class ListaClientesRepository : IListaClientesRepository
    {
        public IList<Cliente> ListarClientes()
        {
            List<Cliente> result = null;
            using (var db = new ClientesDbContext())
            {                
                result =  db.Clientes.ToList().Adapt<List<Cliente>>();                
            }            
            return result;
        }
    }
}
