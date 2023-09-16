using Azure;
using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.API.DTOs.Response;
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

            var clienteDoBanco = this.Buscar(cliente.Celular);

            if (clienteDoBanco != null)
            {
                throw new Exception(message: "Cliente já cadastrado");
            }

            _repository.Cadastrar(cliente);
        }
        public ClienteResponse Buscar(string celular)
        {
            var cliente = _repository.Buscar(celular);
            ClienteResponse response = null;

            if (cliente == null)
            {
                throw new Exception(message: "O Cliente não foi encontrado");
            }

            response = new ClienteResponse()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Documento = cliente.Documento,
                Email = cliente.Email,
                Celular = cliente.Celular,
                Aniversario = cliente.Aniversario,
                DataCadastro = cliente.DataCadastro,
                Endereco = cliente.Endereco
            };

            return response;

        }
    }
}
