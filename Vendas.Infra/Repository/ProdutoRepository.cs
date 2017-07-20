using Vendas.Domain;
using Vendas.Infra.Repository.Interface;

namespace Vendas.Infra.Repository
{
    public class ProdutoRepository: RepositoryBase<Produto>, IProdutoRepository
    {
    }
}
