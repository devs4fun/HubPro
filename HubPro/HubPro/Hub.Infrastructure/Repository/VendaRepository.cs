using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Infrastructure.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ContextHub _contextHub;
        public VendaRepository(ContextHub contextHub)
        {
            _contextHub = contextHub;
        }

        public void Cadastrar(Venda venda)
        {
            _contextHub.Add(venda);
            _contextHub.SaveChanges();
        }

        //public IEnumerable<Venda> BuscarTodos()
        //{
        //    return _contextHub.Vendas;
        //}

        //public Venda BuscarPorId(int id)
        //{
        //    return _contextHub.Vendas.FirstOrDefault(p => p.Id == id);
        //}

        //public void Atualizar(Venda venda)
        //{
        //    _contextHub.Update(venda);
        //    _contextHub.SaveChanges();
        //}

        //public void Deletar(Venda venda)
        //{
        //    _contextHub.Remove(venda);
        //    _contextHub.SaveChanges();
        //}
    }
}
