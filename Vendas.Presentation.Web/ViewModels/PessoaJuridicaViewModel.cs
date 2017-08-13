using System;

namespace Vendas.Presentation.Web.ViewModels
{
    public class PessoaJuridicaViewModel
    {
        public int IdPessoaJuridica { get; set; }
        public string NomeCliente { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public DateTime DataFundacao { get; set; }
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

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioCadastro { get; set; }
        public virtual PessoaUsuarioViewModel UsuarioAlteracao { get; set; }
    }
}
