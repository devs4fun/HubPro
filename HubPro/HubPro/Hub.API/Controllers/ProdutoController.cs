﻿using HubPro.Hub.Application.Interfaces;
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

        public IActionResult Buscar()
        {
            var produtos = _produtoService.Buscar();

            return Ok(produtos);
        }

        public IActionResult BuscarPorId(int id)
        {
            var produto = _produtoService.BuscarPorId(id);

            return Ok(produto);
        }
    }
}
