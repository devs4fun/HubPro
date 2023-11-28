namespace HubPro.Hub.API.DTOs.Request
{
    public class VendaRequest
    {
        public int IdCliente { get; set; }
        public List<ProdutoRequest> Produtos { get; set; }
    }
}
