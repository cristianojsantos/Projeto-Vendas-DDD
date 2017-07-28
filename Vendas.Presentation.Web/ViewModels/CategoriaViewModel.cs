using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int IdCategoria { get; set; }

        [DisplayName("Descrição da Categoria")]
        [MaxLength(30)]
        [MinLength(3)]
        [Required]
        public string DescricaoCategoria { get; set; }

        public int IdUsuarioCadastro { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataAlteracao { get; set; }

        public virtual UsuarioViewModel UsuarioCadastro { get; set; }
        public virtual UsuarioViewModel UsuarioAlteracao { get; set; }
    }
}
