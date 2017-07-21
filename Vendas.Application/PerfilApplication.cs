using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PerfilApplication: ApplicationBase<Perfil>, IPerfilApplication
    {
        private readonly IPerfilService _service;

        public PerfilApplication(IPerfilService service)
            :base(service)
        {
            _service = service;
        }
    }
}
