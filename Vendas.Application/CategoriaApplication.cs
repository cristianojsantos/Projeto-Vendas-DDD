using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class CategoriaApplication : ApplicationBase<Categoria>, ICategoriaApplication
    {
        private readonly ICategoriaService _service;

        public CategoriaApplication(ICategoriaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
