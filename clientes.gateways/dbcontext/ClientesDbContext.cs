using clientes.gateways.model;
using Microsoft.EntityFrameworkCore;


namespace clientes.gateways.dbcontext
{
    public class ClientesDbContext: DbContext 
    {
        public DbSet<ClienteModel> Clientes {get;set;}
        public DbSet<EnderecoModel> Enderecos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clientes.db");
        }        
    }
}