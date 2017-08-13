using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PessoaFisicaApplication: ApplicationBase<PessoaFisica>, IPessoaFisicaApplication
    {
        private readonly IPessoaFisicaService _service;

        public PessoaFisicaApplication(IPessoaFisicaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
