using HubPro.Hub.API.Models.Response;
using HubPro.Hub.Application.Interfaces;
using HubPro.Hub.Infrastructure.Interfaces;

namespace HubPro.Hub.Application.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public BuscarProdutoResponse Buscar()
        {
            var produtos = _produtoRepository.BuscarTodos();

            var produtosResponse = new List<TodosProdutosResponse>();

            if (produtos.Any())
            {
                produtosResponse = produtos.Select(x => new TodosProdutosResponse
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Quantidade = x.Quantidade,
                    Valor = x.Valor,
                    Ativo = x.Ativo,
                    DataCadastro = x.DataCadastro
                }).ToList();
            }
            else
            {
                produtosResponse = new List<TodosProdutosResponse>();
            }

            return new BuscarProdutoResponse(produtosResponse);
        }

        public ProdutoPorIdResponse BuscarPorId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Identificador do produto deve ser informado.");
            }

            var produto = _produtoRepository.BuscarPorId(id);

            if (produto is null)
            {
                return null;
            }
            else
            {
                return new ProdutoPorIdResponse
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Quantidade = produto.Quantidade,
                    Valor = produto.Valor,
                    Ativo = produto.Ativo,
                    DataCadastro = produto.DataCadastro
                };
            }
        }
    }
}
