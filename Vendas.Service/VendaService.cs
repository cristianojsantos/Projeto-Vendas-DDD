using Vendas.Domain;
using Vendas.Infra.Repositor.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    { 
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
