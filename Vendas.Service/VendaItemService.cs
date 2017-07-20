using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class VendaItemService : ServiceBase<VendaItem>, IVendaItemService
    {
        private readonly IVendaItemRepository _repository;

        public VendaItemService(IVendaItemRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
