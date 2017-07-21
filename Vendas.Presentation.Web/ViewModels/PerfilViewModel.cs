using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PerfilViewModel
    {
        [Key]
        public int IdPefil { get; set; }

        [DisplayName()]
        [MaxLength(30)]
        [MinLength(3)]
        [Required]
        public string DescricaoPerfil { get; set; }
    }
}
