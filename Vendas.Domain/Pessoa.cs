using System;
using System.Collections.Generic;

namespace Vendas.Domain
{
    public class Pessoa
    {
        public Pessoa()
        {
            PessoaUsuario = new List<PessoaUsuario>();
            PessoaFisica = new List<PessoaFisica>();
            PessoaJuridica = new List<PessoaJuridica>();
        }

        public int IdPessoa { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<PessoaUsuario> PessoaUsuario { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridica { get; set; }
    }
}
