using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class PerfilUsuarioService: ServiceBase<PerfilUsuario>, IPerfilUsuarioService
    {
        private readonly IPerfilUsuarioRepository _repository;

        public PerfilUsuarioService(IPerfilUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
