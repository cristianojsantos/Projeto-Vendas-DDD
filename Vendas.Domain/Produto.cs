﻿namespace Vendas.Domain
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorCustoProduto { get; set; }
    }
}