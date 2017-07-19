using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class CategoriaConfiguration: EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(p => p.IdCategoria);

            Property(p => p.DescricaoCategoria)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
