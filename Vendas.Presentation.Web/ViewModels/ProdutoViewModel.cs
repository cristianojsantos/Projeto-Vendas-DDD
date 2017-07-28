﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class ProdutoViewModel
    {
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
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataAlteracao { get; set; }

        public virtual UsuarioViewModel UsuarioCadastro { get; set; }
        public virtual UsuarioViewModel UsuarioAlteracao { get; set; }

        public virtual SubCategoriaViewModel SubCategoria { get; set; }

    }
}
