using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>, IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository _repository;

        public PessoaJuridicaService(IPessoaJuridicaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
