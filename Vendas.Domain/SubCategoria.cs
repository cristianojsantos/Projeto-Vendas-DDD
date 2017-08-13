using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class SubCategoria
    {
        public SubCategoria()
        {
            Produto = new List<Produto>();
        }

        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string DescricaoSubCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuario UsuarioCadastro { get; set; }
        public virtual PessoaUsuario UsuarioAlteracao { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
