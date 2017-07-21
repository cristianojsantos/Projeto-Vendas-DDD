using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class VendedorViewModel
    {
        [Key]
        public int IdVendedor { get; set; }

        public int IdLoja { get; set; }

        [DisplayName("Nome do Vendedor")]
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string NomeVendedor { get; set; }

        [DisplayName("Número Matricula")]
        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string MatriculaVendedor { get; set; }

        public virtual LojaViewModel Loja { get; set; }
    }
}
