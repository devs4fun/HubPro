using HubPro.Hub.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace HubPro.Hub.API.DTOs.Request
{
    public class ClienteRequest 
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        [Required]
        public string Celular { get; set; }
        public DateTime Aniversario { get; set; }
        public DateTime DataCadastro { get; set; }
        public Endereco Endereco { get; set; }
    }
}
