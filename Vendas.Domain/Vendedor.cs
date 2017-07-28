using System;

namespace Vendas.Domain
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public int IdLoja { get; set; }
        public string NomeVendedor { get; set; }
        public string MatriculaVendedor { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Usuario UsuarioCadastro { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }
        public virtual Loja Loja { get; set; }
    }
}
