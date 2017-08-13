using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendaItemConfiguration: EntityTypeConfiguration<VendaItem>
    {
        public VendaItemConfiguration()
        {
            HasKey(p => new { p.IdVenda, p.IdLoja, p.IdPessoaUsuario, p.IdPessoa, p.IdProduto, p.SequenciaItem });

            Property(p => p.ValorVenda)
                .IsRequired()
                .HasPrecision(10, 2);

            HasRequired(p => p.Venda)
                .WithMany()
                .HasForeignKey(p => new { p.IdVenda, p.IdLoja, p.IdPessoaUsuario, p.IdPessoa });

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.IdProduto);
        }
    }
}
