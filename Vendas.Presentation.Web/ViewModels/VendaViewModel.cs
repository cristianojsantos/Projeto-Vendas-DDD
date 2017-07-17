using System;

namespace Vendas.Presentation.Web.ViewModels
{
    public class VendaViewModel
    {
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
