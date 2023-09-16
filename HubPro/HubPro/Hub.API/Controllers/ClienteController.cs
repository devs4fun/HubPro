using HubPro.Hub.API.DTOs.Request;
using Microsoft.AspNetCore.Mvc;
using HubPro.Hub.Application.Interfaces;

namespace HubPro.Hub.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteRequest request)
        {
            _clienteService.Cadastrar(request);
            return Ok();
        }

        [HttpGet]
        public IActionResult Buscar(ClienteRequest request)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(ClienteRequest request)
        {  
            return Ok();
        }

        [HttpDelete]
        public IActionResult Deletar(ClienteRequest request)
        {
            return Ok();
        }


    }
}
