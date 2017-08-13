using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            SubCategoria = new List<SubCategoria>();
        }

        public int IdCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuario UsuarioCadastro { get; set; }
        public virtual PessoaUsuario UsuarioAlteracao { get; set; }

        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
    }
}
