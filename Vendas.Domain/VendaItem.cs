namespace Vendas.Domain
{
    public class VendaItem
    {
        public int SequenciaItem { get; set; }
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdPessoa { get; set; }
        public int IdPessoaUsuario { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorVenda { get; set; }

        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
