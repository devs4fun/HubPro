using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Application.Interfaces;
using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Application.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }
        public void Cadastrar(ClienteRequest request)
        {
            Cliente cliente = new(request.Nome, request.Documento, request.Email, request.Celular, request.Aniversario, request.DataCadastro, request.Endereco);

            var clienteDoBanco = this.BuscarClientePorCelular(cliente.Celular);

            if (clienteDoBanco != null)
            {
                throw new Exception(message: "Cliente já cadastrado");
            }

            _repository.Cadastrar(cliente);
        }
        public Cliente BuscarClientePorCelular(string celular)
        {
            var cliente = _repository.BuscarClientePorCelular(celular);
            return cliente;
        }
    }
}
