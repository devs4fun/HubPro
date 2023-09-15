namespace HubPro.Hub.Domain.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
            Valor = default;
            Quantidade = default;
            Ativo = true;
            DataCadastro = DateTime.UtcNow;
        }

        public void AlterarNome(string nome)
        {
            if (Nome != nome)
            {
                Nome = nome;
            }
        }

        public void AlterarValor(decimal valor)
        {
            if (valor >= 0 && valor != Valor)
            {
                Valor = valor;
            }
        }

        public void AlterarQuantidade(double quantidade)
        {
            if (quantidade >= 0 && quantidade != Quantidade)
            {
                Quantidade = quantidade;
            }
        }

        public void AtivarProduto()
        {
            Ativo = true;
        }

        public void DesativarProduto()
        {
            Ativo = false;
        }
    }
}
