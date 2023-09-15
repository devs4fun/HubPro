using HubPro.Hub.API.Models;
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

        public IActionResult Cadastrar(ProdutoCadastroRequest request)
        {
            _produtoService.Cadastrar(request);

            return Ok();
        }
    }
}
