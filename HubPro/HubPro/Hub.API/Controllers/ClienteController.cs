using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClienteController : ControllerBase
    {
        //IClientService _clientService;

        [HttpPost]
        public IActionResult Cadastrar(ClienteRequest request)
        {
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
