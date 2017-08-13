using System.Collections.Generic;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaUsuarioViewModel
    {
        public PessoaUsuarioViewModel()
        {
            SubCategoria = new List<SubCategoriaViewModel>();
            Categoria = new List<CategoriaViewModel>();            
            PessoaFisica = new List<PessoaFisicaViewModel>();
            PessoaJuridica = new List<PessoaJuridicaViewModel>();
            Lojas = new List<LojaViewModel>();
            Produto = new List<ProdutoViewModel>();
        }

        public int IdPessoaUsuario { get; set; }
        public int IdLoja { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual LojaViewModel Loja { get; set; }

        public virtual ICollection<PerfilPessoaUsuarioViewModel> PerfilPessoaUsuario { get; set; }
        public virtual ICollection<SubCategoriaViewModel> SubCategoria { get; set; }
        public virtual ICollection<CategoriaViewModel> Categoria { get; set; }
        public virtual ICollection<PessoaFisicaViewModel> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridicaViewModel> PessoaJuridica { get; set; }
        public virtual ICollection<LojaViewModel> Lojas { get; set; }
        public virtual ICollection<ProdutoViewModel> Produto { get; set; }
    }
}
