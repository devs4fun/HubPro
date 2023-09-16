namespace HubPro.Hub.API.DTOs
{
    public class ProdutoCadastroRequest
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
    }
}
