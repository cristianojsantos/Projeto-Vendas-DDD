namespace Vendas.Domain
{
    public class VendaItem
    {
        public int SequenciaItem { get; set; }
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdVendedor { get; set; }        
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
