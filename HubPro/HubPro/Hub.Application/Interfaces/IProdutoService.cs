using HubPro.Hub.API.Models;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IProdutoService
    {
        void Cadastrar(ProdutoCadastroRequest request);
    }
}
