using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class ProdutoApplication : ApplicationBase<Produto>, IProdutoApplication
    {
        private readonly IProdutoService _service;

        public ProdutoApplication(IProdutoService service)
            :base(service)
        {
            _service = service;
        }
    }
}
