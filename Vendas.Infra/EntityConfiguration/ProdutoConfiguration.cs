using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class ProdutoConfiguration: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.IdProduto);

            Property(p => p.DescricaoProduto)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.ValorProduto)
                .IsRequired()
                .HasPrecision(10, 2);

            Property(p => p.ValorCustoProduto)
                .IsRequired()
                .HasPrecision(10, 2);

            Property(p => p.IdSubCategoria)
                .IsRequired();

            Property(p => p.IdCategoria)
                .IsRequired();

            HasRequired(p => p.SubCategoria)
                .WithMany()
                .HasForeignKey(p => new { p.IdSubCategoria, p.IdCategoria });                
        }
    }
}
