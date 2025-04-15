using CadastroProdutos.Services.OperacoesMenu;
using CadastroProdutos.Services.GerenciadorProdutos;
using CadastroProdutos.Enums.TipoDoProduto;
using CadastroProdutos.Interfaces;

namespace CadastroProdutos.Menu
{
    public class Menu
    {
        private readonly IGerenciarProdutos _gerenciarProdutos;
        private readonly ICadastroProduto _operacoesMenu;

        public Menu()
        {
            _gerenciarProdutos = new GerenciarProdutos();
            _operacoesMenu = new OperacoesMenu(_gerenciarProdutos);
        }
        public void ExecutarMenu()
        {
            while (true)
            {
                Console.WriteLine("Seja Bem Vindo ao Sistema de Cadastro para Produtos.");
                Console.WriteLine("</=================================================/>");
                Console.WriteLine("[1] | Adicionar.");
                Console.WriteLine("[2] | Listar.");
                Console.WriteLine("[3] | Remover.");
                Console.WriteLine("[4] | Atualizar.");
                Console.WriteLine("[5] | Sair.");
                Console.WriteLine("</=================================================/>");
                Console.Write("Opção: ");
                var opcao = Console.ReadLine();
                // Console.Clear();

                switch (opcao)
                {
                    case "1":
                        double TaxaProduto = 0;
                        Console.WriteLine("Informe o Nome do Produto: ");
                        var NomedoProduto = Console.ReadLine();
                        Console.WriteLine("Informe a Descrição do Produto: ");
                        var DescricaoDoProduto = Console.ReadLine();
                        Console.WriteLine("Informe o Tipo de Serviço do Produto [Servico], [Construcao], [Domestico], [Eletronico]: ");
                        var TipoDoProduto = Enum.Parse<ETipoDoProduto>(Console.ReadLine());
                        Console.WriteLine("Informe o Valor do Produto: ");
                        var ValorProduto = double.Parse(Console.ReadLine());
                        _operacoesMenu.CadastrarProduto(NomedoProduto, DescricaoDoProduto, TipoDoProduto, ValorProduto, TaxaProduto);
                        break;
                    case "2":
                        _gerenciarProdutos.ListarProdutos();
                        break;
                    case "3":
                        Console.Write("Para [remover] um produto, por favor indique o código do mesmo: ");
                        var idProduto = Console.ReadLine();
                        _gerenciarProdutos.RemoverProdutos(idProduto);
                        break;
                    case "4":
                        Console.Write("Para [atualizar] um produto, por favor indique o código do mesmo: ");
                        var idProdutoAtualizar = Console.ReadLine();
                        _gerenciarProdutos.AtualizarProdutos(idProdutoAtualizar);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }
            }
        }
    }
}