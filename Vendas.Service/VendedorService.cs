using Vendas.Domain;
using Vendas.Infra.Repositor.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class VendedorService : ServiceBase<Vendedor>, IVendedorService
    {
        private readonly IVendedorRepository _repository;

        public VendedorService(IVendedorRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
