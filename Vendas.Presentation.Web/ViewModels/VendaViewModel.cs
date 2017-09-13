using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vendas.Presentation.Web.ViewModels
{
    public class VendaViewModel
    {
        public VendaViewModel()
        {
            VendaItemViewModel = new List<VendaItemViewModel>();
        }

        [Key]
        public int IdVenda { get; set; }
        [Key]
        public int IdLoja { get; set; }
        [Key]
        public int IdPessoa { get; set; }
        [Key]
        public int IdPessoaUsuario { get; set; }

        [DisplayName("Data da Venda")]
        public DateTime DataVenda { get; set; }

        public virtual PessoaUsuarioViewModel PessoaUsuario { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual ICollection<VendaItemViewModel> VendaItemViewModel { get; set; }
    }
}
