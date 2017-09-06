using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class LojaViewModel
    {
        [Key]
        public int IdLoja { get; set; }

        [DisplayName("Nome da Loja")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string NomeLoja { get; set; }

        [DisplayName("Endereço")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string Endereco { get; set; }

        [DisplayName("Cep")]
        [MaxLength(9)]
        [Required]
        public string Cep { get; set; }

        [DisplayName("Complemento")]
        [MaxLength(30)]        
        public string Complemento { get; set; }

        [DisplayName("Número")]
        [MaxLength(10)]
        public string NumeroEndereco { get; set; }

        [DisplayName("Bairro")]
        [MaxLength(60)]
        [Required]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        [MaxLength(60)]
        [Required]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        [MaxLength(30)]
        [MinLength(2)]
        [Required]
        public string Estado { get; set; }

        public int IdUsuarioCadastro { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataAlteracao { get; set; }

        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }
    }
}
