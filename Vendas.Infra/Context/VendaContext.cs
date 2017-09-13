using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Vendas.Domain;
using Vendas.Infra.EntityConfiguration;

namespace Vendas.Infra.Context
{
    public class VendaContext : DbContext
    {
        static VendaContext()
        {
            Database.SetInitializer<VendaContext>(null);
        }

        public VendaContext()
            : base("Name=VendaContext")
        {
        }

        public DbSet<Loja> Loja { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaItem> VendaItem { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaUsuario> PessoaUsuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilPessoaUsuario> PerfilPessoaUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new LojaConfiguration());
            modelBuilder.Configurations.Add(new PerfilConfiguration());
            modelBuilder.Configurations.Add(new PerfilPessoaUsuarioConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new PessoaFisicaConfiguration());
            modelBuilder.Configurations.Add(new PessoaJuridicaConfiguration());
            modelBuilder.Configurations.Add(new PessoaUsuarioConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new SubCategoriaConfiguration());            
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new VendaItemConfiguration());

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
        }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
