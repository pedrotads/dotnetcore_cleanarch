using System.Collections.Generic;
using clientes.domain;

namespace clientes.usecases
{
    public class ListaClientes: IListaClientes
    {
        private IListaClientesRepository _listaClientes;
        public ListaClientes(IListaClientesRepository listaClientesRepository)
        {
            _listaClientes = listaClientesRepository;
        }

        public IList<Cliente> Listar()
        {
            return _listaClientes.ListarClientes();
        } 
        
    }
}