using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IClienteService
    {
        void Cadastrar(ClienteRequest clienteRequest);
        Cliente BuscarClientePorCelular(string celular);
    }
}
