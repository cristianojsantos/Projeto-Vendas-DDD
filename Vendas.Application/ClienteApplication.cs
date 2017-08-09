using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class ClienteApplication : ApplicationBase<PessoaFisica>, IClienteApplication
    {
        private readonly IClienteService _service;

        public ClienteApplication(IClienteService service)
            :base(service)
        {
            _service = service;
        }        
    }
}
