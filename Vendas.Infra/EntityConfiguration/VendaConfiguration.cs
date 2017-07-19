using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendaConfiguration: EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(p => new { p.IdVenda, p.IdLoja, p.IdVendedor, p.IdCliente });

            Property(p => p.DataVenda)
                .IsRequired();

            HasRequired(p => p.Vendedor)
                .WithMany()
                .HasForeignKey(p => new { p.IdVendedor, p.IdLoja });
        }
    }
}
