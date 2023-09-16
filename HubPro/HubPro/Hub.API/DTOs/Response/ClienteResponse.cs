using HubPro.Hub.Domain.Models;

namespace HubPro.Hub.API.DTOs.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public DateTime Aniversario { get; set; }
        public DateTime DataCadastro { get; set; }
        public Endereco Endereco { get; set; }
    }
}
