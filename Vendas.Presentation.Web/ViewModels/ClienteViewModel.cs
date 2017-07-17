using System;

namespace Vendas.Presentation.Web.ViewModels
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }
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
    }
}
