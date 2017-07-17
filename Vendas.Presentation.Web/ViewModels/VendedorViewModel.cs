namespace Vendas.Presentation.Web.ViewModels
{
    public class VendedorViewModel
    {
        public int IdVendedor { get; set; }
        public int IdLoja { get; set; }
        public string NomeVendedor { get; set; }
        public string MatriculaVendedor { get; set; }

        public virtual LojaViewModel Loja { get; set; }
    }
}
