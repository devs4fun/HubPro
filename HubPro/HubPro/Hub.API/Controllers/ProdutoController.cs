using HubPro.Hub.API.Models.Request;
using HubPro.Hub.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.API.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Cadastrar()
        {
            return Ok();
        }

        public IActionResult Atualizar(ProdutoRequest request)
        {
            _produtoService.Atualizar(request);
            return Ok();
        }
    }
}
