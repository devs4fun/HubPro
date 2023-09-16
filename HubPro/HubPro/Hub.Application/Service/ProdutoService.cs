using HubPro.Hub.API.Models;
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
    }
}
