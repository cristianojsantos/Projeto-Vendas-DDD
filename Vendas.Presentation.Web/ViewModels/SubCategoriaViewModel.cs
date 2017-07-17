namespace Vendas.Presentation.Web.ViewModels
{
    public class SubCategoriaViewModel
    {
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string DescricaoSubCategoria { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}
