using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendaConfiguration: EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(p => new { p.IdVenda, p.IdLoja, p.IdPessoaUsuario, p.IdPessoa });

            Property(p => p.DataVenda)
                .IsRequired();

            HasRequired(p => p.PessoaUsuario)
                .WithMany()
                .HasForeignKey(p => new { p.IdPessoa, p.IdLoja });

            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.IdPessoa);
        }
    }
}
