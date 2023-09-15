namespace HubPro.Hub.API.Models.Response
{
    public class BuscarProdutoResponse
    {
        public List<TodosProdutosResponse> Produtos { get; set; }

        public BuscarProdutoResponse(List<TodosProdutosResponse> produtos)
        {
            Produtos = produtos;
        }
    }
}
