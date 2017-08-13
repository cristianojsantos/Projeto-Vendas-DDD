using System;

namespace Vendas.Domain
{
    public class PessoaFisica
    {
        public int IdPessoaFisica { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
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

        public virtual Pessoa Pessoa { get; set; }
        public virtual PessoaUsuario UsuarioCadastro { get; set; }
        public virtual PessoaUsuario UsuarioAlteracao { get; set; }
    }
}
