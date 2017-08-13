using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PessoaJuridicaApplication: ApplicationBase<PessoaJuridica>, IPessoaJuridicaApplication
    {
        private readonly IPessoaJuridicaService _service;

        public PessoaJuridicaApplication(IPessoaJuridicaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
