using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PerfilPessoaUsuarioConfiguration: EntityTypeConfiguration<PerfilPessoaUsuario>
    {
        public PerfilPessoaUsuarioConfiguration()
        {
            HasKey(p => new { p.IdPerfil, p.IdPessoaUsuario, p.IdLoja });

            HasRequired(p => p.Perfil)
                .WithMany()
                .HasForeignKey(p => p.IdPerfil);

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => new { p.IdPessoaUsuario, p.IdLoja });
        }
    }
}
