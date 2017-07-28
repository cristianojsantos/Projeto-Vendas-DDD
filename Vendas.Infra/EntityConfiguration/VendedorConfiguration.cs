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

            Property(p => p.IdUsuarioCadastro)
                .IsRequired();

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.IdUsuarioAlteracao);

            Property(p => p.DataAlteracao);

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => p.IdUsuarioCadastro);

            HasOptional(p => p.UsuarioAlteracao)
                .WithMany()
                .HasForeignKey(p => p.IdUsuarioAlteracao);
        }
    }
}
