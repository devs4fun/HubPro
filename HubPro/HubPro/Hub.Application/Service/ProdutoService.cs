using Azure.Core;
using HubPro.Hub.API.Models.Request;
using HubPro.Hub.Domain.Models;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Application.Service
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Atualizar(ProdutoRequest request)
        {
            var produto = BuscarEAplicarAlteracoes(request);

            _produtoRepository.Atualizar(produto);
        }

        private Produto BuscarEAplicarAlteracoes(ProdutoRequest request)
        {
            var produto = BuscarProduto(request.Id);

            produto.AlterarNome(request.Nome);
            produto.AlterarQuantidade(request.Quantidade);
            produto.AlterarValor(request.Valor);

            if (request.Ativo is true)
            {
                produto.AtivarProduto();
            }
            else
            {
                produto.DesativarProduto();
            }

            return produto;
        }

        private Produto BuscarProduto(int id)
        {
            var produto = _produtoRepository.BuscarPorId(id);

            if (produto is null)
            {
                throw new Exception("Produto não pode ser atualizado pois não foi encontrado.");
            }

            return produto;
        }
    }
}
