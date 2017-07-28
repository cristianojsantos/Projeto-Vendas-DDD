using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int IdCliente { get; set; }

        [DisplayName("Nome do Cliente")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string NomeCliente { get; set; }

        [DisplayName("Número do CPF")]
        [MaxLength(14)]
        [MinLength(5)]
        [Required]
        public string Cpf { get; set; }

        [DisplayName("Número do RG")]
        [MaxLength(14)]
        [MinLength(5)]
        [Required]
        public string Rg { get; set; }

        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Endereço")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string Endereco { get; set; }

        [DisplayName("Endereço")]
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
        [MaxLength(30)]
        [Required]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        [MaxLength(60)]
        [Required]
        public string Cidade { get; set; }

        [DisplayName("Endereço")]
        [MaxLength(30)]
        [Required]
        public string Estado { get; set; }

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
