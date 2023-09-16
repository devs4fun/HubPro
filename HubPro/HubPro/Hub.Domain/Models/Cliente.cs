namespace HubPro.Hub.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento  { get;  set; }
        public string Email { get;  set; }
        public string Celular { get; set; }
        public DateTime Aniversario { get; set; }
        public DateTime DataCadastro { get; private set; }
        public Endereco Endereco { get; set; }

        public Cliente() 
        { 
        }

        public Cliente(string nome, string documento, string email, string celular, DateTime aniversario, DateTime dataCadastro, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            Celular = celular;
            Aniversario = aniversario;
            DataCadastro = DateTime.UtcNow;
            Endereco = endereco;
        }
    }
}
