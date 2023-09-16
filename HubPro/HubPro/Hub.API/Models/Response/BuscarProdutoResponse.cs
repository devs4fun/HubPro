namespace HubPro.Hub.API.Models.Response
{
    public class BuscarProdutoResponse
    {
        public List<ProdutoResponse> Produtos { get; set; }

        public BuscarProdutoResponse(List<ProdutoResponse> produtos)
        {
            Produtos = produtos;
        }
    }
}
