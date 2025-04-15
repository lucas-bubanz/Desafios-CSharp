using CadastroProdutos.Enums.TipoDoProduto;

namespace CadastroProdutos.Interfaces
{
    public interface ICadastroProduto
    {
        void CadastrarProduto(string nomeDoProduto,
                             string descricaoDoProduto,
                             ETipoDoProduto tipoDoProduto,
                             double valorProduto);
    }
}