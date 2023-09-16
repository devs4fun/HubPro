using HubPro.Hub.API.Models;
using HubPro.Hub.API.Models.Request;
using HubPro.Hub.API.Models.Response;
using HubPro.Hub.Application.Interfaces;
using HubPro.Hub.Domain.Models;
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
            if (id <= 0) throw new Exception("Identificador do produto deve ser informado.");

            var produto = BuscarProduto(id);

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

        public void Cadastrar(ProdutoCadastroRequest request)
        {
            Produto produto = new(nome: request.Nome,
                                  valor: request.Valor,
                                  quantidade: request.Quantidade,
                                  ativo: request.Ativo);

            produto.Validar();

            _produtoRepository.Cadastrar(produto);
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

        public void Excluir(int id)
        {
            if (id > 0)
            {
                _produtoRepository.Deletar(id);
            }
        }

        public void DesativarProduto(int id)
        {
            var produto = BuscarProduto(id);

            produto.DesativarProduto();

            _produtoRepository.Atualizar(produto);
        }

        private Produto BuscarProduto(int id)
        {
            var produto = _produtoRepository.BuscarPorId(id);

            if (produto is null)
            {
                throw new Exception("Produto não foi encontrado.");
            }

            return produto;
        }
    }
}