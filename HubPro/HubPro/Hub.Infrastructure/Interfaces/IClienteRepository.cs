using HubPro.Hub.API.DTOs.Response;
using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.Infrastructure.Interfaces
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);
        Cliente Buscar(string celular);
        void Atualizar(Cliente cliente);
        void Deletar(Cliente id);
        IEnumerable<Cliente> BuscarTudo(int pg);
    }
}
