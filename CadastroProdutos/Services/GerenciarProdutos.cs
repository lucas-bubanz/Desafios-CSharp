using CadastroProdutos.Enums.TipoDoProduto;
using CadastroProdutos.Models.Produtos;
using CadastroProdutos.Interfaces;

namespace CadastroProdutos.Services.GerenciadorProdutos
{
    public class GerenciarProdutos : TaxaProdutos, IGerenciarProdutos
    {
        private readonly List<Produtos> _ListaDeProdutos;

        public GerenciarProdutos()
        {
            _ListaDeProdutos = new List<Produtos>();
        }

        public void AdicionaProduto(Produtos produto)
        {
            _ListaDeProdutos.Add(produto);
            Console.WriteLine("Produto Cadastrado com Sucesso");
        }

        public void AtualizarProdutos(string idProdutoAtualizar)
        {
            var produtoEncontrado = _ListaDeProdutos.FirstOrDefault(id => id.CodigoDoProduto.Equals(idProdutoAtualizar));
            if (produtoEncontrado == null)
            {
                Console.WriteLine("Produto não encontrado pelo ID fornecido.");
                return;
            }
            while (true)
            {
                Console.WriteLine($"Escolha o que deseja atualizar no produto '{produtoEncontrado.NomedoProduto}':");
                Console.WriteLine("1 - Nome do Produto");
                Console.WriteLine("2 - Descrição do Produto");
                Console.WriteLine("3 - Tipo do Produto");
                Console.WriteLine("4 - Valor do Produto");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o novo nome do produto: ");
                        produtoEncontrado.NomedoProduto = Console.ReadLine();
                        Console.WriteLine("Nome do produto atualizado com sucesso!");
                        break;
                    case "2":
                        Console.Write("Digite a nova descrição do produto: ");
                        produtoEncontrado.DescricaoDoProduto = Console.ReadLine();
                        Console.WriteLine("Descrição do produto atualizada com sucesso!");
                        break;
                    case "3":
                        Console.Write("Digite o novo tipo do produto [Servico], [Construcao], [Domestico], [Eletronico]: ");
                        produtoEncontrado.TipoDoProduto = Enum.Parse<ETipoDoProduto>(Console.ReadLine());
                        Console.WriteLine("Tipo do produto atualizado com sucesso!");
                        break;
                    case "4":
                        Console.Write("Digite o novo valor do produto: ");
                        if (double.TryParse(Console.ReadLine(), out double novoValor))
                        {
                            Console.WriteLine("Manter a mesma taxa? ");
                            Console.WriteLine("[S] - Sim | [N] - Não ");
                            var escolha = Console.ReadLine();

                            if (escolha.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                            {
                                produtoEncontrado.ValorProduto = novoValor;
                                Console.WriteLine("Valor do produto atualizado com sucesso!");
                                Console.Write("Mantendo a mesma taxa.");
                            }
                            else
                            {
                                Console.WriteLine("Qual o valor da nova taxa: ");
                                double ValorDaTaxa = double.Parse(Console.ReadLine());
                                double valorAtualizadoComTaxa = TaxaSobTipoDeProduto(novoValor, ValorDaTaxa);
                                produtoEncontrado.ValorProduto = valorAtualizadoComTaxa;
                                Console.WriteLine("Valor do produto atualizado com a nova taxa!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Atualização não realizada.");
                        }
                        break;
                    case "0":
                        Console.WriteLine("Saindo do menu de atualização.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        public void ListarProdutos()
        {
            if (_ListaDeProdutos.Count == 0)
            {
                Console.WriteLine("Não há produtos cadastrados.");
                return;
            }
            Console.WriteLine("<=== Lista de Produtos Cadastrados ===>");
            foreach (var produto in _ListaDeProdutos)
            {
                if (_ListaDeProdutos.Count == 0)
                {
                    Console.WriteLine("Não há produtos cadastrados.");
                    return;
                }
                Console.WriteLine($"Código do Produto: {produto.CodigoDoProduto}");
                Console.WriteLine($"Nome do Produto: {produto.NomedoProduto}");
                Console.WriteLine($"Descrição do Produto: {produto.DescricaoDoProduto}");
                Console.WriteLine($"Tipo do Produto: {produto.TipoDoProduto}");
                Console.WriteLine($"Valor do Produto: {produto.ValorProduto:C}");
                Console.WriteLine("<|=======================================================|>");
            }
        }

        public void RemoverProdutos(string idProduto)
        {
            var produtoEncontrado = _ListaDeProdutos.FirstOrDefault(id => id.CodigoDoProduto.Equals(idProduto));
            if (produtoEncontrado == null)
            {
                Console.WriteLine("Produto não encontrado pelo ID fornecido.");
                return;
            }

            _ListaDeProdutos.Remove(produtoEncontrado);
            Console.WriteLine("Produto removido com sucesso!");
        }

        public override double TaxaSobTipoDeProduto(double ValorProduto, double ValorDaTaxa)
        {
            ValorProduto += (ValorProduto * ValorDaTaxa);
            return ValorProduto;
        }


    }
}