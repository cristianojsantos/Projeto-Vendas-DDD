using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PessoaJuridicaConfiguration : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaConfiguration()
        {
            HasKey(p => p.IdPessoaJuridica);

            Property(p => p.NomeCliente)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.InscricaoEstadual)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.InscricaoMunicipal)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.DataFundacao)
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
                .WithMany(p => p.PessoaJuridica)
                .HasForeignKey(p => new { p.IdPessoaUsuarioAlteracao, p.IdLojaAlteracao });
        }
    }
}
