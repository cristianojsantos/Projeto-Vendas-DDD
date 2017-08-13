using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PerfilPessoaUsuarioApplication: ApplicationBase<PerfilPessoaUsuario>, IPerfilPessoaUsuarioApplication
    {
        private readonly IPerfilPessoaUsuarioService _service;

        public PerfilPessoaUsuarioApplication(IPerfilPessoaUsuarioService service)
            :base(service)
        {
            _service = service;
        }
    }
}
