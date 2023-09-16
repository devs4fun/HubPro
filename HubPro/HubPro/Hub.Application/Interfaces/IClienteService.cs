using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.API.DTOs.Response;
using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IClienteService
    {
        void Cadastrar(ClienteRequest clienteRequest);
        ClienteResponse Buscar(string celular);
        void Atualizar(ClienteRequest clienteRequest);
        void Deletar(string id);
    }
}
