using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        readonly ContextHub _contextHub;
        public ClienteRepository(ContextHub contextHub)
        {
            _contextHub = contextHub;
        }

        public Cliente BuscarClientePorCelular(string celular)
        {
            return _contextHub.Cliente.FirstOrDefault(x => x.Celular == celular);
        }

        public void Cadastrar(Cliente cliente)
        {
            _contextHub.Add(cliente);
            _contextHub.SaveChanges();
        }
    

    }
}
