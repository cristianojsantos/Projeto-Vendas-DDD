using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class LojaApplication : ApplicationBase<Loja>, ILojaApplication
    {
        private readonly ILojaService _service;

        public LojaApplication(ILojaService service)
            :base(service)
        {
            _service = service;
        }
    }
}
