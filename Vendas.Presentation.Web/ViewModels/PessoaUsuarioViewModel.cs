using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaUsuarioViewModel
    {
        public PessoaUsuarioViewModel()
        {
            SubCategoriaViewModel = new List<SubCategoriaViewModel>();
            CategoriaViewModel = new List<CategoriaViewModel>();            
            PessoaFisicaViewModel = new List<PessoaFisicaViewModel>();
            PessoaJuridicaViewModel = new List<PessoaJuridicaViewModel>();
            LojaViewModel = new List<LojaViewModel>();
            ProdutoViewModel = new List<ProdutoViewModel>();
        }

        [Key]
        [Column(Order = 1)]
        public int IdPessoaUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdLoja { get; set; }

        [DisplayName("Nome do Usuário")]
        [Required]
        [MaxLength(60)]
        public string NomeUsuario { get; set; }

        [DisplayName("Login do Usuário")]
        [Required]
        [MaxLength(15)]
        public string LoginUsuario { get; set; }

        [DisplayName("Senha")]
        [Required]
        [MaxLength(60)]
        [DataType(DataType.Password)]
        public string SenhaUsuario { get; set; }

        [Display(Name = "E-mail")]
        [MaxLength(200)]
        public string EmailUsuario { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual LojaViewModel Loja { get; set; }

        public virtual ICollection<PerfilPessoaUsuarioViewModel> PerfilPessoaUsuarioViewModel { get; set; }
        public virtual ICollection<SubCategoriaViewModel> SubCategoriaViewModel { get; set; }
        public virtual ICollection<CategoriaViewModel> CategoriaViewModel { get; set; }
        public virtual ICollection<PessoaFisicaViewModel> PessoaFisicaViewModel { get; set; }
        public virtual ICollection<PessoaJuridicaViewModel> PessoaJuridicaViewModel { get; set; }
        public virtual ICollection<LojaViewModel> LojaViewModel { get; set; }
        public virtual ICollection<ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
