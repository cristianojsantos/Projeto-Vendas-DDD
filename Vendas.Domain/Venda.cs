using System;

namespace Vendas.Domain
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public int IdLoja { get; set; }
        public int IdPessoaVendedor { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual PessoaVendedor Vendedor { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
