using System;

namespace Vendas.Domain
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorCustoProduto { get; set; }
        public int IdPessoaUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PerfilPessoaUsuario UsuarioCadastro { get; set; }
        public virtual PerfilPessoaUsuario UsuarioAlteracao { get; set; }

        public virtual SubCategoria SubCategoria { get; set; }
    }
}
