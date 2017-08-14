using System;
using System.Collections.Generic;

namespace Vendas.Presentation.Web.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            SubCategoria = new List<SubCategoriaViewModel>();
        }

        public int IdCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }

        public virtual ICollection<SubCategoriaViewModel> SubCategoria { get; set; }
    }
}
