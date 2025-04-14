using CadastroProdutos.Enums.TipoDoProduto;
using CadastroProdutos.Models.Produtos;

namespace CadastroProdutos.Services.GerenciadorProdutos
{
    public class GerenciarProdutos : TaxaProdutos
    {
        private readonly List<Produtos> _ListaDeProdutos;

        public GerenciarProdutos()
        {
            _ListaDeProdutos = new List<Produtos>();
        }

        public override double TaxaSobTipoDeProduto(double ValorProduto, double ValorDaTaxa)
        {
            ValorProduto += (ValorProduto * ValorDaTaxa);
            return ValorProduto;
        }

        public void AdicionaProduto(Produtos produto)
        {
            _ListaDeProdutos.Add(produto);
            Console.WriteLine("Produto Cadastrado com Sucesso");
        }

    }
}