using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class PerfilPessoaUsuarioService: ServiceBase<PerfilPessoaUsuario>, IPerfilPessoaUsuarioService
    {
        private readonly IPerfilPessoaUsuarioRepository _repository;

        public PerfilPessoaUsuarioService(IPerfilPessoaUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
