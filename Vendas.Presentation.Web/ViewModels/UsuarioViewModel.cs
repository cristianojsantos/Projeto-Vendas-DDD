using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [DisplayName("Nome do Usuário")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string NomeUsuario { get; set; }

        [DisplayName("Senha do Usuário")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        [DataType(DataType.Password)]
        public string SenhaUsuario { get; set; }

        [DisplayName("E-mail do Usuário")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        [DataType(DataType.Password)]
        public string EmailUsuario { get; set; }
    }
}
