using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [DisplayName("Nome do Usuario")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        public string NomeUsuario { get; set; }

        [DisplayName("Login do Usuario")]
        [MaxLength(20)]
        [MinLength(3)]
        [Required]
        public string LoginUsuario { get; set; }

        [DisplayName("Senha do Usuario")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        [DataType(DataType.Password)]
        public string SenhaUsuario { get; set; }

        [DisplayName("E-mail do Usuario")]
        [MaxLength(100)]
        [MinLength(5)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailUsuario { get; set; }
    }
}
