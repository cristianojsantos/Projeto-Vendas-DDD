using AutoMapper;
using Vendas.Domain;
using Vendas.Presentation.Web.ViewModels;

namespace Vendas.Presentation.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<LojaViewModel, Loja>();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<SubCategoriaViewModel, SubCategoria>();
            CreateMap<VendaItemViewModel, VendaItem>();
            CreateMap<VendaViewModel, Venda>();
            CreateMap<VendedorViewModel, Vendedor>();
            CreateMap<PerfilViewModel, Perfil>();
            CreateMap<PerfilUsuarioViewModel, PerfilUsuario>();
            CreateMap<UsuarioViewModel, PerfilUsuario>();
        }
    }
}