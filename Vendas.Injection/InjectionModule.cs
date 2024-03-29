﻿using Ninject.Modules;
using Vendas.Application;
using Vendas.Application.Interface;
using Vendas.Infra.Repository;
using Vendas.Infra.Repository.Interface;
using Vendas.Service;
using Vendas.Service.Interface;

namespace Vendas.Injection
{
    public class InjectionModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IApplicationBase<>)).To(typeof(ApplicationBase<>));
            Bind<ICategoriaApplication>().To<CategoriaApplication>();
            Bind<ISubCategoriaApplication>().To<SubCategoriaApplication>();
            Bind<IProdutoApplication>().To<ProdutoApplication>();
            Bind<ILojaApplication>().To<LojaApplication>();
            Bind<IVendaApplication>().To<VendaApplication>();
            Bind<IVendaItemApplication>().To<VendaItemApplication>();
            Bind<IClienteApplication>().To<ClienteApplication>();
            Bind<IPessoaUsuarioApplication>().To<PessoaoUsuarioApplication>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<ICategoriaService>().To<CategoriaService>();
            Bind<ISubCategoriaService>().To<SubCategoriaService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<ILojaService>().To<LojaService>();
            Bind<IVendaService>().To<VendaService>();
            Bind<IVendaItemService>().To<VendaItemService>();
            Bind<IClienteService>().To<ClienteService>();
            Bind<IPessoaUsuarioService>().To<PessoaUsuarioService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<ICategoriaRepository>().To<CategoriaRepository>();
            Bind<ISubCategoriaRepository>().To<SubCategoriaRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<ILojaRepository>().To<LojaRepository>();
            Bind<IVendaRepository>().To<VendaRepository>();
            Bind<IVendaItemRepository>().To<VendaItemRepository>();
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IPessoaUsuarioRepository>().To<PessoaUsuarioRepository>();
        }
    }
}
