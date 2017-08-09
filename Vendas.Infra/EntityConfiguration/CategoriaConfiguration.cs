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

            Property(p => p.IdPessoaUsuarioCadastro)
                .IsRequired();

            Property(p => p.DataCadastro)
                .IsRequired();
            
            Property(p => p.DataAlteracao);

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => p.IdPessoaUsuarioCadastro);

            HasOptional(p => p.UsuarioAlteracao)
                .WithMany(p => p.Categoria)
                .HasForeignKey(p => p.IdPessoaUsuarioAlteracao);

        }
    }
}
