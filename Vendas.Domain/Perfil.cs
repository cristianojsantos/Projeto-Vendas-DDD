using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Perfil
    {
        public Perfil()
        {
            PerfilPessoaUsuario = new List<PerfilPessoaUsuario>();
        }

        public int IdPefil { get; set; }
        public string DescricaoPerfil { get; set; }

        public ICollection<PerfilPessoaUsuario> PerfilPessoaUsuario { get; set; }
    }
}
