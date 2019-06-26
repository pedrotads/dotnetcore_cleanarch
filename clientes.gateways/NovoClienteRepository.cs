
using clientes.domain;
using clientes.gateways.dbcontext;
using clientes.gateways.model;
using clientes.usecases;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace clientes.gateways
{
    public class NovoClienteRepository : INovoClienteRepository
    {        
        public Cliente Novo(Cliente cliente)
        {
            var newClient = cliente.Adapt<ClienteModel>();
            using (var db = new ClientesDbContext())
            {                
                db.Clientes.Add(newClient);
                var count = db.SaveChanges();
            }
            return newClient.Adapt<Cliente>();
        }
    }
}
