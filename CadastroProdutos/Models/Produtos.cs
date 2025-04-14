using CadastroProdutos.Enums.TipoDoProduto;

namespace CadastroProdutos.Models.Produtos
{
    public class Produtos
    {
        public string CodigoDoProduto { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);
        public string NomedoProduto { get; set; }
        public string DescricaoDoProduto { get; set; }
        public ETipoDoProduto TipoDoProduto { get; set; }
        public double ValorProduto { get; set; }
    }
}