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
            CreateMap<ClienteViewModel, PessoaFisica>();
            CreateMap<LojaViewModel, Loja>();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<SubCategoriaViewModel, SubCategoria>();
            CreateMap<VendaItemViewModel, VendaItem>();
            CreateMap<VendaViewModel, Venda>();
            CreateMap<PerfilViewModel, Perfil>();
            CreateMap<PerfilPessoaUsuarioViewModel, PerfilPessoaUsuario>();
            CreateMap<PessoaUsuarioViewModel, PerfilPessoaUsuario>();
        }
    }
}