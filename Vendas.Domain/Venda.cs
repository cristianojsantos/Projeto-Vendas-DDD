using System;

namespace Vendas.Domain
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdPessoa { get; set; }
        public int IdPessoaUsuario { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual PessoaUsuario PessoaUsuario { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
