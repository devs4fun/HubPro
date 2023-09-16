using HubPro.Hub.API.DTOs;
using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.API.DTOs.Response;
using HubPro.Hub.Infrastructure.Interfaces;
using HubPro.Hub.Infrastructure.Repository;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoResponse> Buscar();
        ProdutoResponse BuscarPorId(int id);
        void Cadastrar(ProdutoCadastroRequest request);
        void Atualizar(ProdutoRequest request);
        void Excluir(int id);
        void DesativarProduto(int id);
    }
}
