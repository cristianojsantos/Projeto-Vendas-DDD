using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class SubCategoriaConfiguration: EntityTypeConfiguration<SubCategoria>
    {
        public SubCategoriaConfiguration()
        {
            HasKey(p => new { p.IdSubCategoria, p.IdCategoria });

            Property(p => p.DescricaoSubCategoria)
                .IsRequired()
                .HasMaxLength(60);

            HasRequired(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.IdCategoria);
        }
    }
}
