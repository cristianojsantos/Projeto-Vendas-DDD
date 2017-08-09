using System;

namespace Vendas.Domain
{
    public class PessoaVendedor
    {
        public PessoaVendedor()
        {

        }

        public int IdPessoaVendedor { get; set; }
        public int IdLoja { get; set; }
        public string NomeVendedor { get; set; }
        public string MatriculaVendedor { get; set; }
        public int IdPessoaUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PerfilPessoaUsuario UsuarioCadastro { get; set; }
        public virtual PerfilPessoaUsuario UsuarioAlteracao { get; set; }
        public virtual Loja Loja { get; set; }
    }
}
