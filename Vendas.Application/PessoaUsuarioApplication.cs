using Vendas.Application.Interface;
using Vendas.Domain;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class PessoaoUsuarioApplication: ApplicationBase<PessoaUsuario>, IPessoaUsuarioApplication
    {
        private readonly IPessoaUsuarioService _service;

        public PessoaoUsuarioApplication(IPessoaUsuarioService service)
            :base(service)
        {
            _service = service;
        }
    }
}
