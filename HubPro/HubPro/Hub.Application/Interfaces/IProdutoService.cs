using HubPro.Hub.API.Models.Response;
using HubPro.Hub.Infrastructure.Interfaces;
using HubPro.Hub.Infrastructure.Repository;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IProdutoService
    {
        BuscarProdutoResponse Buscar();

        ProdutoResponse BuscarPorId(int id);
    }
}
