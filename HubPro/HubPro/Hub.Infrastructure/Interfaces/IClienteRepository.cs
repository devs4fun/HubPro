using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.Infrastructure.Interfaces
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        Cliente BuscarClientePorCelular(string celular);
    }
}
