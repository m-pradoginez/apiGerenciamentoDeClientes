using GerenciamentoDeClientes.Core;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeClientes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;
        public ClientesController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            return Ok(_clienteServices.GetClientes());
        }

        [HttpGet("{id}", Name = "GetCliente")]
        public IActionResult GetCliente(string id)
        {
            return Ok(_clienteServices.GetCliente(id));
        }

        [HttpPost]
        public IActionResult AddCliente(Cliente cliente)
        {
            _clienteServices.AddCliente(cliente);
            return CreatedAtRoute("GetCliente", new { id = cliente.Id }, cliente);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            _clienteServices.DeleteCliente(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCliente(Cliente cliente)
        {
            return Ok(_clienteServices.UpdateCliente(cliente));
        }
    }
}
