using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.Infrastructure.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> BuscarTodos();

        Produto? BuscarPorId(int id);

        void Cadastrar(Produto produto);

        void Atualizar(Produto produto);

        void Deletar(int id);
    }
}
