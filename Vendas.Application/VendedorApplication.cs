using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class VendedorApplication : ApplicationBase<Vendedor>, IVendedorApplication
    {
        private readonly IVendedorService _service;

        public VendedorApplication(IVendedorService service)
            :base(service)
        {
            _service = service;
        }
    }
}
