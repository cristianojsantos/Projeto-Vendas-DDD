using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class UsuarioApplication: ApplicationBase<Usuario>, IUsuarioApplication
    {
        private readonly IUsuarioService _service;

        public UsuarioApplication(IUsuarioService service)
            :base(service)
        {
            _service = service;
        }
    }
}
