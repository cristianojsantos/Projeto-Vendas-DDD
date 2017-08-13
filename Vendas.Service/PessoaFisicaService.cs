using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class PessoaFisicaService: ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _repository;

        public PessoaFisicaService(IPessoaFisicaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
