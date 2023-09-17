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
        [Route("BuscarPorIdentificador")]
        public IActionResult BuscarPorIdentificador(string request)
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

        [HttpGet]
        [Route("BuscarVarios")]
        public IActionResult BuscarVarios(int pg)
        {
            var clientes = _clienteService.BuscarTudo(pg);
            if (clientes == null)
            {
                return BadRequest("Clientes não encontrados");
            }

            return Ok(clientes);
        }

        [HttpPut]
        public IActionResult Atualizar(ClienteRequest request)
        {
            _clienteService.Atualizar(request);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Deletar(string id)
        {
            _clienteService.Deletar(id);
            return Ok();
        }


    }
}
