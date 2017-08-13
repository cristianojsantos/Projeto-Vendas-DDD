using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PessoaFisicaConfiguration: EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfiguration()
        {
            HasKey(p => p.IdPessoaFisica);

            Property(p => p.NomeCliente)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Cpf)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.Rg)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnType("date");

            Property(p => p.Endereco)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Cep)
                .HasMaxLength(9)
                .IsRequired();

            Property(p => p.Complemento)
                .HasMaxLength(30)
                .IsOptional();

            Property(p => p.NumeroEndereco)
                .HasMaxLength(10)
                .IsOptional();

            Property(p => p.Bairro)
                .HasMaxLength(60)
                .IsRequired();

            Property(p => p.Cidade)
                .HasMaxLength(60)
                .IsRequired();

            Property(p => p.Estado)
                .HasMaxLength(30)
                .IsRequired();
                        
            Property(p => p.DataCadastro)
                .IsRequired();
                        
            Property(p => p.DataAlteracao);

            HasRequired(p => p.UsuarioCadastro)
                .WithMany()
                .HasForeignKey(p => new { p.IdPessoaUsuarioCadastro, p.IdLojaCadastro });

            HasOptional(p => p.UsuarioAlteracao)
                .WithMany(p => p.PessoaFisica)
                .HasForeignKey(p => new { p.IdPessoaUsuarioAlteracao, p.IdLojaAlteracao });
        }
    }
}
