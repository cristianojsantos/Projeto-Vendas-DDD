using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class VendaApplication : ApplicationBase<Venda>, IVendaApplication
    {
        private readonly IVendaService _service;

        public VendaApplication(IVendaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
