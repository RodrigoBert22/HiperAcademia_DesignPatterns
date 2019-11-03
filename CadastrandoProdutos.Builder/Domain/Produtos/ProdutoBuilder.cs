using CadastrandoProdutos.Builder.Domain.Produtos.Origens;
using System;

namespace CadastrandoProdutos.Builder.Domain.Produtos
{
    class ProdutoBuilder
    {
        public int Codigo { get; set; }
        public Guid IdExterno { get; set; }
        public string Nome { get; set; }
        public decimal SaldoEmEstoque { get; set; }
        public Origem Origem { get; set; }
        public DateTime? DataDeImportacao { get; set; }
        public int? NumeroDaNotaFiscalDeImportacao { get; set; }
        public int? IdDoAplicativoExterno { get; set; }

        public Produto Build()
        {
            return new Produto(Codigo, Nome, SaldoEmEstoque, Origem, DataDeImportacao, NumeroDaNotaFiscalDeImportacao, IdDoAplicativoExterno);
        }

        public ProdutoBuilder WithCodigo(int codigo)
        {
            Codigo = codigo;
            return this;
        }

        public ProdutoBuilder WithIdExterno(Guid idExterno)
        {
            IdExterno = idExterno;
            return this;
        }

        public ProdutoBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ProdutoBuilder WithSaldoEmEstoque(decimal saldoEmEstoque)
        {
            SaldoEmEstoque = saldoEmEstoque;
            return this;
        }

        public ProdutoBuilder WithOrigem(Origem origem)
        {
            Origem = origem;
            return this;
        }

        public ProdutoBuilder WithDataDeImportacao(DateTime? dataDeImportacao)
        {
            DataDeImportacao = dataDeImportacao;
            return this;
        }

        public ProdutoBuilder WithNumeroDaNotaFiscalDeImportacao(int? numeroDaNotaFiscalDeImportacao)
        {
            NumeroDaNotaFiscalDeImportacao = numeroDaNotaFiscalDeImportacao;
            return this;
        }

        public ProdutoBuilder WithIdDoAplicativoExterno(int? idDoAplicativoExterno)
        {
            IdDoAplicativoExterno = idDoAplicativoExterno;
            return this;
        }
    }
}
