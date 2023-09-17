using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HubPro.Hub.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        readonly ContextHub _contextHub;
        public ClienteRepository(ContextHub contextHub)
        {
            _contextHub = contextHub;
        }

        public void Atualizar(Cliente cliente)
        {
            _contextHub.Update(cliente);
            _contextHub.SaveChanges();
        }

        public Cliente Buscar(string request)
        {
            int.TryParse(request, out int id);

            return _contextHub.Cliente
                .Include(c => c.Endereco)
                .FirstOrDefault(x => x.Celular == request || x.Nome == request || x.Id == id);
        }

        public IEnumerable<Cliente> BuscarTudo(int pg)
        {
            int itensPorPagina = 10; // Número de itens por página

            return _contextHub.Cliente
                .OrderBy(c => c.Nome)
                .Skip((pg - 1) * itensPorPagina)
                .Take(itensPorPagina)
                .Include(c => c.Endereco);
        }

        public void Cadastrar(Cliente cliente)
        {
            _contextHub.Add(cliente);
            _contextHub.SaveChanges();  
        }

        public void Deletar(Cliente cliente)
        {
            _contextHub.Cliente.Remove(cliente);
            _contextHub.SaveChanges();
        }
    }
}
