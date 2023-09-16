using HubPro.Hub.API.Models;
using HubPro.Hub.API.Models.Response;
using HubPro.Hub.Infrastructure.Interfaces;
using HubPro.Hub.Infrastructure.Repository;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IProdutoService
    {
        void Cadastrar(ProdutoCadastroRequest request);

        IEnumerable<ProdutoResponse> Buscar();

        ProdutoResponse BuscarPorId(int id);
    }
}
