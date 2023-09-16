using HubPro.Hub.API.Models.Request;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IProdutoService
    {
        void Atualizar(ProdutoRequest request);
    }
}
