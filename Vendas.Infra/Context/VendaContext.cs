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
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaItem> VendaItem { get; set; }
        public DbSet<PessoaFisica> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new LojaConfiguration());
            modelBuilder.Configurations.Add(new VendedorConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new SubCategoriaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new VendaItemConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new PerfilConfiguration());
            modelBuilder.Configurations.Add(new PerfilUsuarioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
        }
    }
}
