using HubPro.Hub.API.Models;
using HubPro.Hub.API.Models.Response;
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

        public void Cadastrar(ProdutoCadastroRequest request)
        {
            Produto produto = new(nome: request.Nome,
                                  valor: request.Valor,
                                  quantidade: request.Quantidade,
                                  ativo: request.Ativo);

            produto.Validar();

            _produtoRepository.Cadastrar(produto);
        }

        public IEnumerable<ProdutoResponse> Buscar()
        {
            var produtos = _produtoRepository.BuscarTodos();

            var produtosResponse = new List<ProdutoResponse>();

            if (produtos.Any())
            {
                produtosResponse = produtos.Select(x => new ProdutoResponse
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Quantidade = x.Quantidade,
                    Valor = x.Valor,
                    Ativo = x.Ativo,
                    DataCadastro = x.DataCadastro
                }).ToList();
            }

            return produtosResponse;
        }

        public ProdutoResponse BuscarPorId(int id)
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
                return new ProdutoResponse
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