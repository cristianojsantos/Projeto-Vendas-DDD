using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            SubCategoriaViewModel = new List<SubCategoriaViewModel>();
        }

        [Key]
        public int IdCategoria { get; set; }

        [DisplayName("Descrição da Categoria")]
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string DescricaoCategoria { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }

        [DisplayName("Data de Alteração")]
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuarioViewModel UsuarioCadastroViewModel { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracaoViewModel { get; set; }

        public virtual ICollection<SubCategoriaViewModel> SubCategoriaViewModel { get; set; }
    }
}
