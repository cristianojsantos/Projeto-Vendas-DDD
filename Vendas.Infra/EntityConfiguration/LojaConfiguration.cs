using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class LojaConfiguration: EntityTypeConfiguration<Loja>
    {
        public LojaConfiguration()
        {
            HasKey(p => p.IdLoja);

            Property(p => p.NomeLoja)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Endereco)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Cep)
                .IsRequired()
                .HasMaxLength(9);

            Property(p => p.Complemento)
                .HasMaxLength(30);

            Property(p => p.NumeroEndereco)
                .HasMaxLength(10);

            Property(p => p.Bairro)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(30);
                        
            Property(p => p.DataCadastro)
                .IsRequired();
            
            Property(p => p.DataAlteracao)
                .IsOptional();

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => new { p.IdPessoaUsuarioCadastro, p.IdLojaCadastro });

            HasOptional(p => p.UsuarioAlteracao)
                .WithMany(p => p.Lojas)
                .HasForeignKey(p => new { p.IdPessoaUsuarioAlteracao, p.IdLojaAlteracao });
        }
    }
}
