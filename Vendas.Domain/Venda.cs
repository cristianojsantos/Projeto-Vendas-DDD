using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Venda
    {
        public Venda()
        {
            Pessoa = new List<Pessoa>();
            PessoaUsuario = new List<PessoaUsuario>();
        }

        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdPessoa { get; set; }
        public int IdPessoaUsuario { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual List<PessoaUsuario> PessoaUsuario { get; set; }

        public virtual List<Pessoa> Pessoa { get; set; }
    }
}
