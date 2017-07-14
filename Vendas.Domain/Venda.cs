using System;

namespace Vendas.Domain
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
