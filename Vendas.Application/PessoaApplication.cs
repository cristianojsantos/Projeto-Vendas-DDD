using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PessoaApplication: ApplicationBase<Pessoa>, IPessoaApplication
    {
        private readonly IPessoaService _service;

        public PessoaApplication(IPessoaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
