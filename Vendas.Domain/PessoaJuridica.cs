using System;

namespace Vendas.Domain
{
    public class PessoaJuridica
    {
        public int IdPessoaJuridica { get; set; }
        public string NomeCliente { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public int IdPessoaUsuarioCadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdPessoaUsuarioAlteracao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual PerfilPessoaUsuario UsuarioCadastro { get; set; }
        public virtual PerfilPessoaUsuario UsuarioAlteracao { get; set; }
    }
}
