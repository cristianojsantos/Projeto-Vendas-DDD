using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class UsuarioService: ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        } 
    }
}
