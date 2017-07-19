using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendaItemConfiguration: EntityTypeConfiguration<VendaItem>
    {
        public VendaItemConfiguration()
        {
            HasKey(p => new { p.IdVenda, p.IdLoja, p.IdVendedor, p.IdCliente, p.IdProduto, p.SequenciaItem });

            Property(p => p.ValorVenda)
                .IsRequired()
                .HasPrecision(10, 2);
        }
    }
}
