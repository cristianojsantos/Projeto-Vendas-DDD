using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class PessoaUsuarioService: ServiceBase<PessoaUsuario>, IPessoaUsuarioService
    {
        private readonly IPessoaUsuarioRepository _repository;

        public PessoaUsuarioService(IPessoaUsuarioRepository repository)
            :base(repository)
        {
            _repository = repository;
        } 
    }
}
