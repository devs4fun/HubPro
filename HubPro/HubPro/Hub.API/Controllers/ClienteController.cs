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
        public IActionResult Buscar(string request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var cliente = _clienteService.Buscar(request);
            if(cliente == null)
            {
                return BadRequest("Cliente não encontrado");
            }

            return Ok(cliente);
        }

        [HttpPut]
        public IActionResult Atualizar(ClienteRequest request)
        {
            _clienteService.Atualizar(request);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Deletar(ClienteRequest request)
        {
            return Ok();
        }


    }
}
