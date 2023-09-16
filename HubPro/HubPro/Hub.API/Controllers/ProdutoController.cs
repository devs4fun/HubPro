using HubPro.Hub.API.DTOs;
using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("Buscar")]
        public IActionResult Buscar()
        {
            var produtos = _produtoService.Buscar();

            return Ok(produtos);
        }

        [HttpGet]
        [Route("BuscarPorId/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var produto = _produtoService.BuscarPorId(id);

            return Ok(produto);
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(ProdutoCadastroRequest request)
        {
            _produtoService.Cadastrar(request);

            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(ProdutoRequest request)
        {
            _produtoService.Atualizar(request);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            _produtoService.Excluir(id);
            return Ok();
        }

        [HttpPost]
        [Route("DesativarProduto")]
        public IActionResult DesativarProduto(int id)
        {
            _produtoService.DesativarProduto(id);
            return Ok();
        }
    }
}
