using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Presentation.Web.ViewModels
{
    public class VendaViewModel
    {
        [Key]
        [Column(Order = 1)]
        public int IdVenda { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdLoja { get; set; }

        [Key]
        [Column(Order = 3)]
        public int IdVendedor { get; set; }

        [Key]
        [Column(Order = 4)]
        public int IdCliente { get; set; }

        [Required]
        [DisplayName("Data da Venda")]
        [DataType(DataType.Date)]
        public DateTime DataVenda { get; set; }
    }
}
