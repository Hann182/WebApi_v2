using WebApi_v2.Model;

namespace WebApi_v2.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _clienteRepository.GetClient
        }

        public Cliente SetCliente()
        {

        }

    }
}
