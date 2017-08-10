using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PessoaUsuarioConfiguration: EntityTypeConfiguration<PessoaUsuario>
    {
        public PessoaUsuarioConfiguration()
        {
            HasKey(p => p.IdPessoaUsuario);

            Property(p => p.NomeUsuario)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.SenhaUsuario)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.EmailUsuario)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
