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

            Property(p => p.IdUsuarioCadastro)
                .IsRequired();

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.IdUsuarioAlteracao);

            Property(p => p.DataAlteracao);

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => p.IdUsuarioCadastro);

            HasRequired(p => p.UsuarioAlteracao)
                .WithMany()
                .HasForeignKey(p => p.IdUsuarioAlteracao);

        }
    }
}
