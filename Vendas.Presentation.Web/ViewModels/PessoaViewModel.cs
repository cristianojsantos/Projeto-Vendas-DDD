using System;
using System.Collections.Generic;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaViewModel
    {
        public PessoaViewModel()
        {
            PessoaUsuario = new List<PessoaUsuarioViewModel>();
            PessoaFisica = new List<PessoaFisicaViewModel>();
            PessoaJuridica = new List<PessoaJuridicaViewModel>();
        }

        public int IdPessoa { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<PessoaUsuarioViewModel> PessoaUsuario { get; set; }
        public virtual ICollection<PessoaFisicaViewModel> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridicaViewModel> PessoaJuridica { get; set; }
    }
}
