using CadastroProdutos.Models.Produtos;
using CadastroProdutos.Services.GerenciadorProdutos;
using CadastroProdutos.Enums.TipoDoProduto;

namespace CadastroProdutos.Services.OperacoesMenu
{

    public class OperacoesMenu
    {
        private readonly static GerenciarProdutos gerenciarProdutos = new();
        private static Produtos produto = new();
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
                var novoValorProdutoComTaxa = gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.1);
                produto.ValorProduto = novoValorProdutoComTaxa;
                gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Domestico)
            {
                var novoValorProdutoComTaxa = gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.05);
                produto.ValorProduto = novoValorProdutoComTaxa;
                gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Servico)
            {
                var novoValorProdutoComTaxa = gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.2);
                produto.ValorProduto = novoValorProdutoComTaxa;
                gerenciarProdutos.AdicionaProduto(produto);
            }
            else if (produto.TipoDoProduto == ETipoDoProduto.Construcao)
            {
                var novoValorProdutoComTaxa = gerenciarProdutos.TaxaSobTipoDeProduto(produto.ValorProduto, 0.3);
                produto.ValorProduto = novoValorProdutoComTaxa;
                gerenciarProdutos.AdicionaProduto(produto);
            }
        }
    }
}