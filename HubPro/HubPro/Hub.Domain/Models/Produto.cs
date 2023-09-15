
using HubPro.Hub.Domain.ErroModels;

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

        public Produto(string nome, decimal valor = 0, double quantidade = 0, bool ativo = true)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Ativo = ativo;
            DataCadastro = DateTime.UtcNow;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
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

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception(message: "O produto deve ter um nome.");
            }

            if (Valor < 0)
            {
                throw new Exception(message: "Valor do produto não pode ser menor que zero.");
            }

            if (Quantidade < 0)
            {
                throw new Exception(message: "Quantidade de produtos não pode ser menor que zero.");
            }
        }
    }
}
