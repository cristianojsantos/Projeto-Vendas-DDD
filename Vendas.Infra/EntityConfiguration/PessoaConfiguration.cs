using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PessoaConfiguration: EntityTypeConfiguration<Pessoa>
    {
        public PesoaConfiguration()
        {
            HasKey(p => p.IdPessoa);

            Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnType("date");
        }
    }
}
