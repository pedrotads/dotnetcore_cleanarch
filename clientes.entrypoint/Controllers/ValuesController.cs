using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clientes.domain;
using clientes.entrypoint.view;
using clientes.usecases;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace clientes.entrypoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IListaClientes _listaClientes;
        private INovoCliente _novoCliente;
        public ClientesController(IListaClientes listaClientes,
        INovoCliente novoCliente)
        {
            _listaClientes = listaClientes;
            _novoCliente = novoCliente;
            
        }
        
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IList<ClienteViewModel>> Get()
        {
            ActionResult<IList<ClienteViewModel>> clientesResult = _listaClientes.Listar().Adapt<IList<ClienteViewModel>>().ToList();
            return clientesResult;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<ClienteViewModel> Post([FromBody] ClienteViewModel value)
        {
            var result = _novoCliente.Novo(value.Adapt<Cliente>());
            return result.Adapt<ClienteViewModel>();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
