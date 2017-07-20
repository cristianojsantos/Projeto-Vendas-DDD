using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PerfilConfiguration: EntityTypeConfiguration<Perfil>
    {
        public PerfilConfiguration()
        {
            HasKey(p => p.IdPefil);

            Property(p => p.DescricaoPerfil)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
