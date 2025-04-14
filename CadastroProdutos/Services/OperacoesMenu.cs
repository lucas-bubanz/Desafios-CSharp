using CadastroProdutos.Models.Produtos;
using CadastroProdutos.Services.GerenciadorProdutos;
using CadastroProdutos.Enums.TipoDoProduto;

namespace CadastroProdutos.Services.OperacoesMenu
{

    public class OperacoesMenu
    {
        private readonly GerenciarProdutos _gerenciarProdutos;
        private static Produtos produto = new();

        public OperacoesMenu(GerenciarProdutos gerenciarProdutos)
        {
            _gerenciarProdutos = gerenciarProdutos;
        }
        public void CadastrarProduto(string NomedoProduto, string DescricaoDoProduto, ETipoDoProduto TipoDoProduto, double ValorProduto)
        {
            produto = new Produtos
            {
                NomedoProduto = NomedoProduto,
                DescricaoDoProduto = DescricaoDoProduto,
                TipoDoProduto = TipoDoProduto,
                ValorProduto = ValorProduto
            };
            if (produto.TipoDoProduto == ETipoDoProduto.Eletronico)
            {
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.1);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Domestico)
            {
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.05);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Servico)
            {
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.2);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Construcao)
            {
                var novoValorProdutoComTaxa = _gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.3);
                produto.ValorProduto = novoValorProdutoComTaxa;
                _gerenciarProdutos.AdicionaProduto(produto);
            }
        }
    }
}