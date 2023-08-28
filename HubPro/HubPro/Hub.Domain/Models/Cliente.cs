namespace HubPro.Hub.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF  { get; protected set; }
        public string Email { get; protected set; }
        public int Senha { get; protected set; }

        public Cliente() 
        { 
        }
    }
}
