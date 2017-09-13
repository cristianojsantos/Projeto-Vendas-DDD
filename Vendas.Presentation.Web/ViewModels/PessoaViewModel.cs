using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Key]
        public int IdPessoa { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<PessoaUsuarioViewModel> PessoaUsuario { get; set; }
        public virtual ICollection<PessoaFisicaViewModel> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridicaViewModel> PessoaJuridica { get; set; }
    }
}
