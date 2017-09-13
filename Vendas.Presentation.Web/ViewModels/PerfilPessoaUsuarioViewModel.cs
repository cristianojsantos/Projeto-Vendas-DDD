using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PerfilPessoaUsuarioViewModel
    {
        public PerfilPessoaUsuarioViewModel()
        {
            PerfilViewModel = new List<PerfilViewModel>();
            PessoaUsuarioViewModel = new List<PessoaUsuarioViewModel>();
        }

        [Key]
        [Column(Order = 1)]
        public int IdPerfil { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdUsuario { get; set; }

        public virtual ICollection<PerfilViewModel> PerfilViewModel { get; set; }

        public virtual ICollection<PessoaUsuarioViewModel> PessoaUsuarioViewModel { get; set; }
    }
}
