using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class UsuarioConfiguration: EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(p => p.IdUsuario);

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
