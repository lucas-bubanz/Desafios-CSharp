namespace CadastroProdutos.Interfaces
{
    public interface IGerenciarProdutos
    {
        void AdicionaProduto(Models.Produtos.Produtos produto);
        void ListarProdutos();
        void RemoverProdutos(string idProduto);
        void AtualizarProdutos(string idProdutoAtualizar);
        // double TaxaSobTipoDeProduto(double valorProduto, double valorDaTaxa);
    }
}