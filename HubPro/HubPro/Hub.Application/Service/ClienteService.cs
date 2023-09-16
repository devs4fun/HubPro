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
            Cliente cliente = new (request.Nome, request.Documento, request.Email, request.Celular, request.Aniversario, request.DataCadastro, request.Endereco);

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
                return response;
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

        public void Atualizar(ClienteRequest clienteRequest)
        {
            var clienteDoBanco = _repository.Buscar(clienteRequest.Celular);

            if(clienteDoBanco == null) 
            {
                throw new Exception(message: "O Cliente não foi encontrado para atualizar");
            }

            clienteDoBanco.Nome = clienteRequest.Nome;
            clienteDoBanco.Documento = clienteRequest.Documento;
            clienteDoBanco.Email = clienteRequest.Email;
            clienteDoBanco.Celular = clienteRequest.Celular;
            clienteDoBanco.Aniversario = clienteRequest.Aniversario;
            clienteDoBanco.Endereco = new Endereco();
            clienteDoBanco.Endereco.Rua = clienteRequest.Endereco.Rua;
            clienteDoBanco.Endereco.Bairro = clienteRequest.Endereco.Bairro;
            clienteDoBanco.Endereco.Numero = clienteRequest.Endereco.Numero;
            clienteDoBanco.Endereco.Estado = clienteRequest.Endereco.Estado;
            clienteDoBanco.Endereco.Cep = clienteRequest.Endereco.Cep;
            clienteDoBanco.Endereco.Complemento = clienteRequest.Endereco.Complemento;
            clienteDoBanco.Endereco.Observacoes = clienteRequest.Endereco.Observacoes;

            _repository.Atualizar(clienteDoBanco);
        }
    }
}
