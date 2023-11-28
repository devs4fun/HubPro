using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _vendaService;
        public VendaController(IVendaService vendaService)
        {
                _vendaService = vendaService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(VendaRequest venda)
        {
            _vendaService.Cadastrar(venda);

            return Ok();
        }
    }
}
