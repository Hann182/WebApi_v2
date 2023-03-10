using Microsoft.AspNetCore.Mvc;

namespace WebApi_v2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        
        [HttpGet]
        [Route("ConsultaClientes")]
        public Cliente GetCliente(int idCliente)
        {
            ClienteService clienteService = new ClienteService();
            return clienteService.ConsultaClienteTratado(idCliente);
        }

        [HttpPost]
        [Route("InsereCliente")]
        public IActionResult SetCliente([FromBody] InsereClienteRequest cliente)
        {
            try
            {
                ClienteService clienteService = new ClienteService();
                clienteService.InsereClienteTratado(cliente);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            // Falta a verificação do estoque
        }
    }
}