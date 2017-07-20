using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class LojaService : ServiceBase<Loja>, ILojaService
    {
        private readonly ILojaRepository _repository;

        public LojaService(ILojaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
