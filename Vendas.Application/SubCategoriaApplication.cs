using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class SubCategoriaApplication : ApplicationBase<SubCategoria>, ISubCategoriaApplication
    {
        private readonly ISubCategoriaService _service;

        public SubCategoriaApplication(ISubCategoriaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
