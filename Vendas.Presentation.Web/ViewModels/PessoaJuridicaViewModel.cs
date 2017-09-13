using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaJuridicaViewModel
    {
        [Key]
        public int IdPessoaJuridica { get; set; }

        [DisplayName("Nome do Cliente")]
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string NomeCliente { get; set; }

        [DisplayName("Número do CNPJ")]
        [MaxLength(14)]
        [Required]
        public string Cnpj { get; set; }

        [DisplayName("Número da Inscrição Estadual")]
        [MaxLength(14)]
        [Required]
        public string InscricaoEstadual { get; set; }

        [DisplayName("Número da Inscrição Municipal")]
        [MaxLength(14)]
        [Required]
        public string InscricaoMunicipal { get; set; }

        [DisplayName("Data de Fundação")]        
        public DateTime DataFundacao { get; set; }

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

        [Display(Name = "Data de Cadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }

        [DisplayName("Data de Alteração")]
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }
    }
}
