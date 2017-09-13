using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaFisicaViewModel
    {
        [Key]
        public int IdPessoaFisica { get; set; }

        [DisplayName("Nome do Cliente")]
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string NomeCliente { get; set; }

        [DisplayName("Número do CPF")]
        [MaxLength(14)]
        [Required]
        public string Cpf { get; set; }

        [DisplayName("Número do RG")]
        [MaxLength(14)]
        public string Rg { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required]        
        public DateTime DataNascimento { get; set; }

        [DisplayName("Endereço")]
        [Required]
        [MaxLength(60)]
        public string Endereco { get; set; }

        [DisplayName("Cep")]
        [Required]
        [MaxLength(9)]
        public string Cep { get; set; }

        [DisplayName("Complemento")]
        [MaxLength(10)]
        public string Complemento { get; set; }

        [DisplayName("Número do Endereço")]
        [MaxLength(10)]
        [MinLength(2)]
        public string NumeroEndereco { get; set; }

        [DisplayName("Bairro")]
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Estado { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }
    }
}
