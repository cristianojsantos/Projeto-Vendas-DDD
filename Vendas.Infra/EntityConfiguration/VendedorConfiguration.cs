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
                .HasMaxLength(100)
                .HasColumnType("varchar");

        }
    }
}
