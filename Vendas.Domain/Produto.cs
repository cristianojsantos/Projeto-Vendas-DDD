using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Produto
    {
        public Produto()
        {
            VendaItem = new List<VendaItem>();
        }

        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string CodigoBarras { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorCustoProduto { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuario UsuarioCadastro { get; set; }
        public virtual PessoaUsuario UsuarioAlteracao { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }

        public virtual ICollection<VendaItem> VendaItem { get; set; }
    }
}
