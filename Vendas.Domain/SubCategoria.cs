namespace Vendas.Domain
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string DescricaoSubCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
