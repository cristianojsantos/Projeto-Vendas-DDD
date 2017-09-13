using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {

        }

        [Key]
        public int IdProduto { get; set; }

        [DisplayName("Descrição do Produto")]
        [MaxLength(60)]
        [MinLength(6)]
        [Required]
        public string DescricaoProduto { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        
        [Required]
        [DisplayName("Valor do Produto")]
        [DataType(DataType.Currency)]
        public decimal ValorProduto { get; set; }

        [Required]
        [DisplayName("Valor Custo do Produto")]
        [DataType(DataType.Currency)]
        public decimal ValorCustoProduto { get; set; }

        public int IdUsuarioCadastro { get; set; }

        [DisplayName("Data Cadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataAlteracao { get; set; }

        public virtual ICollection<PessoaUsuarioViewModel> PessoaUsuarioCadastroViewModel { get; set; }
        public virtual ICollection<PessoaUsuarioViewModel> PessoaUsuarioUsuarioAlteracaoViewModel { get; set; }
        public virtual ICollection<SubCategoriaViewModel> SubCategoriaViewModel { get; set; }
        public virtual ICollection<VendaItemViewModel> VendaItemViewModel { get; set; }
    }
}
