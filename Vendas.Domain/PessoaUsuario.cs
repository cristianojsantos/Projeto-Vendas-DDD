﻿using System.Collections.Generic;

namespace Vendas.Domain
{
    public class PessoaUsuario
    {
        public PessoaUsuario()
        {
            Vendedor = new List<PessoaVendedor>();
            SubCategoria = new List<SubCategoria>();
            Categoria = new List<Categoria>();
            PessoaFisica = new List<PessoaFisica>();
        }

        public int IdPessoaUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public virtual ICollection<PessoaVendedor> Vendedor { get; set; }
        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }
    }
}