﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PerfilPessoaUsuarioViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int IdPerfil { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdUsuario { get; set; }

        public virtual PerfilViewModel Perfil { get; set; }
        public virtual PessoaUsuarioViewModel Usuario { get; set; }
    }
}
