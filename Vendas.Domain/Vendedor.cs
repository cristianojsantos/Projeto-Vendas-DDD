namespace Vendas.Domain
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public int IdLoja { get; set; }
        public string NomeVendedor { get; set; }
        public string MatriculaVendedor { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
