using HubPro.Hub.API.DTOs.Request;

namespace HubPro.Hub.Application.Interfaces
{
    public interface IVendaService
    {
        void Cadastrar(VendaRequest vendaRequest);

    }
}
