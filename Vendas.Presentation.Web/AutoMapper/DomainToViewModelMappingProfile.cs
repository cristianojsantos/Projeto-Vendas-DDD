using AutoMapper;
using Vendas.Domain;
using Vendas.Presentation.Web.ViewModels;

namespace Vendas.Presentation.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<PessoaFisica, ClienteViewModel>();
            CreateMap<Loja, LojaViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<SubCategoria, SubCategoriaViewModel>();
            CreateMap<VendaItem, VendaItemViewModel>();
            CreateMap<Venda, VendaViewModel>();
            CreateMap<Vendedor, VendedorViewModel>();
            CreateMap<Perfil, PerfilViewModel>();
            CreateMap<PerfilUsuario, PerfilUsuarioViewModel>();
            CreateMap<Usuario, PerfilUsuarioViewModel>();
        }
    }
}