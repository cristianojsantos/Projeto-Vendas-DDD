using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendedorConfiguration: EntityTypeConfiguration<Vendedor>
    {
        public VendedorConfiguration()
        {
            HasKey(p => new { p.IdVendedor, p.IdLoja });

            Property(p => p.NomeVendedor)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.MatriculaVendedor)
                .IsRequired()
                .HasMaxLength(15);

            HasRequired(p => p.Loja)
                .WithMany()
                .HasForeignKey(p => p.IdLoja);
        }
    }
}
