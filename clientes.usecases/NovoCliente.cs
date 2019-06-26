using System;
using clientes.domain;

namespace clientes.usecases
{
    public class NovoCliente : INovoCliente
    {
        private  INovoClienteRepository _novoClienteRepository;
        public NovoCliente(INovoClienteRepository novoClienteRepository)
        {
            _novoClienteRepository = novoClienteRepository;
        }
        
        public Cliente Novo(Cliente cliente)
        {
            return _novoClienteRepository.Novo(cliente);
        }
    }
}
