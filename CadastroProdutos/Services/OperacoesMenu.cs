using CadastroProdutos.Models.Produtos;
using CadastroProdutos.Enums.TipoDoProduto;
using CadastroProdutos.Interfaces;

namespace CadastroProdutos.Services.OperacoesMenu
{

    public class OperacoesMenu : ICadastroProduto
    {
        private readonly IGerenciarProdutos _gerenciarProdutos;
        private static Produtos produto = new();

        public OperacoesMenu(IGerenciarProdutos gerenciarProdutos)
        {
            _gerenciarProdutos = gerenciarProdutos;
        }
        public void CadastrarProduto(string NomedoProduto, string DescricaoDoProduto, ETipoDoProduto TipoDoProduto, double ValorProduto, double TaxaProduto)
        {
            produto = new Produtos
            {
                NomedoProduto = NomedoProduto,
                DescricaoDoProduto = DescricaoDoProduto,
                TipoDoProduto = TipoDoProduto,
                ValorProduto = ValorProduto,
                TaxaProduto = TaxaProduto
            };
            if (produto.TipoDoProduto == ETipoDoProduto.Eletronico)
            {
                produto.TaxaProduto = 0.1;
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, produto.TaxaProduto);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Domestico)
            {
                produto.TaxaProduto = 0.05;
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, produto.TaxaProduto);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Servico)
            {
                produto.TaxaProduto = 0.2;
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, produto.TaxaProduto);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Construcao)
            {
                produto.TaxaProduto = 0.3;
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, produto.TaxaProduto);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
        }
    }
}