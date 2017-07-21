using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class VendaItemViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int SequenciaItem { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdVenda { get; set; }

        [Key]
        [Column(Order = 3)]
        public int IdLoja { get; set; }

        [Key]
        [Column(Order = 4)]
        public int IdVendedor { get; set; }

        [Key]
        [Column(Order = 5)]
        public int IdCliente { get; set; }

        [Key]
        [Column(Order = 6)]
        public int IdProduto { get; set; }

        [Required]
        [DisplayName("Valor da Venda")]
        [DataType(DataType.Currency)]
        public decimal ValorVenda { get; set; }

        public virtual VendaViewModel Venda { get; set; }
    }
}
