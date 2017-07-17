using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class VendaItemApplication : ApplicationBase<VendaItem>, IVendaItemApplication
    {
        private readonly IVendaItemService _service;

        public VendaItemApplication(IVendaItemService service)
            :base(service)
        {
            _service = service;
        }
    }
}
