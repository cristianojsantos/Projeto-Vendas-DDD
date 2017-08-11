using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class UsuarioService: ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IPessoaUsuarioRepository _repository;

        public UsuarioService(IPessoaUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        } 
    }
}
