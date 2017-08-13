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

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.DataAlteracao);

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => new { p.IdPessoaUsuarioCadastro, p.IdLojaCadastro });

            HasOptional(p => p.UsuarioAlteracao)
                .WithMany(p => p.SubCategoria)
                .HasForeignKey(p => new { p.IdPessoaUsuarioAlteracao, p.IdLojaAlteracao });
        }
    }
}
