using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        readonly ContextHub _contextHub;
        public ProdutoRepository(ContextHub contextHub)
        {
            _contextHub = contextHub;
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            return _contextHub.Produtos;
        }

        public Produto? BuscarPorId(int id)
        {
            return _contextHub.Produtos.FirstOrDefault(p => p.id == id);
        }

        public void Cadastrar(Produto produto)
        {
            _contextHub.Add(produto);
            _contextHub.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _contextHub.Update(produto);
            _contextHub.SaveChanges();
        }

        public void Deletar(int id)
        {
            _contextHub.Remove(id);
            _contextHub.SaveChanges();
        }
    }
}
