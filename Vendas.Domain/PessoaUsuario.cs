﻿using System.Collections.Generic;

namespace Vendas.Domain
{
    public class PessoaUsuario
    {
        public PessoaUsuario()
        {
            SubCategoria = new List<SubCategoria>();
            Categoria = new List<Categoria>();            
            PessoaFisica = new List<PessoaFisica>();
            PessoaJuridica = new List<PessoaJuridica>();
            Lojas = new List<Loja>();
            Produto = new List<Produto>();
        }

        public int IdPessoaUsuario { get; set; }
        public int IdLoja { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Loja Loja { get; set; }

        public virtual ICollection<PerfilPessoaUsuario> PerfilPessoaUsuario { get; set; }
        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual ICollection<Loja> Lojas { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
