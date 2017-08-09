using System;

namespace Vendas.Domain
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string DescricaoSubCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int IdPessoaUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PerfilPessoaUsuario UsuarioCadastro { get; set; }
        public virtual PerfilPessoaUsuario UsuarioAlteracao { get; set; }
    }
}
