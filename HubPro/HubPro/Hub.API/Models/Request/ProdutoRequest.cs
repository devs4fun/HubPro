namespace HubPro.Hub.API.Models.Request
{
    public class ProdutoRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
    }
}
