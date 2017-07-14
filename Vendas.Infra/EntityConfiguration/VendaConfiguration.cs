using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class VendaConfiguration: EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {

        }
    }
}
