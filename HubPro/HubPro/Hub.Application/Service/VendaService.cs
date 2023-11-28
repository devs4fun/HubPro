using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Application.Interfaces;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Application.Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        private readonly IClienteService _clienteService;
        public VendaService(IVendaRepository repository, IClienteService clienteService)
        {
            _repository = repository;
            _clienteService = clienteService;
        }
        public void Cadastrar(VendaRequest vendaRequest)
        {
            var cliente = _clienteService.Buscar(vendaRequest.IdCliente.ToString());

            _repository.Cadastrar(venda);
        }
    }
}
