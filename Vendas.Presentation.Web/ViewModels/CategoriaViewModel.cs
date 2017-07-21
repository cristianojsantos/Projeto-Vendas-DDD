﻿using System.ComponentModel;
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
    }
}
