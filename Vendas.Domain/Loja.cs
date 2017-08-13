using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Loja
    {
        public Loja()
        {
            Venda = new List<Venda>();
        }

        public int IdLoja { get; set; }
        public string NomeLoja { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public int IdLojaCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public int? IdLojaAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PessoaUsuario UsuarioCadastro { get; set; }
        public virtual PessoaUsuario UsuarioAlteracao { get; set; }

        public virtual ICollection<Venda> Venda { get; set; }
    }
}
