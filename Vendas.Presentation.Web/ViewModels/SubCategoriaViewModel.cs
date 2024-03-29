﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class SubCategoriaViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int IdSubCategoria { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdCategoria { get; set; }

        [DisplayName("Descrição Sub-Categoria")]
        [Required]
        [MaxLength(60)]
        [MinLength(6)]
        public string DescricaoSubCategoria { get; set; }

        public int IdUsuarioCadastro { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }

        [DisplayName("Data Cadastro")]
        [Required]
        public DateTime DataAlteracao { get; set; }

        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }
    }
}
