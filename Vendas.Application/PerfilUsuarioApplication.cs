using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PerfilUsuarioApplication: ApplicationBase<PerfilUsuario>, IPerfilUsuarioApplication
    {
        private readonly IPerfilUsuarioService _service;

        public PerfilUsuarioApplication(IPerfilUsuarioService service)
            :base(service)
        {
            _service = service;
        }
    }
}
