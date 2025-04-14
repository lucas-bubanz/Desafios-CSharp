using CadastroProdutos.Services.OperacoesMenu;
using CadastroProdutos.Enums.TipoDoProduto;
namespace CadastroProdutos.Menu
{
    public class Menu
    {
        public void ExecutarMenu()
        {
            var operacoesMenu = new OperacoesMenu();
            while (true)
            {
                Console.WriteLine("Seja Bem Vindo ao Sistema de Cadastro para Produtos.");
                Console.WriteLine("</=================================================/>");
                Console.WriteLine("[1] | Adicionar.");
                Console.WriteLine("[2] | Listar.");
                Console.WriteLine("[3] | Remover.");
                Console.WriteLine("[4] | Buscar pelo Nome.");
                Console.WriteLine("[5] | Buscar pelo Serviço.");
                Console.WriteLine("[6] | Ordenar Produtos.");
                Console.WriteLine("[7] | Sair.");
                Console.WriteLine("</=================================================/>");
                Console.Write("Opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Informe o Nome do Produto: ");
                        var NomedoProduto = Console.ReadLine();
                        Console.WriteLine("Informe a Descrição do Produto: ");
                        var DescricaoDoProduto = Console.ReadLine();
                        Console.WriteLine("Informe o Tipo de Serviço do Produto [Servico], [Construcao], [Domestico], [Eletronico]: ");
                        var TipoDoProduto = Enum.Parse<ETipoDoProduto>(Console.ReadLine());
                        Console.WriteLine("Informe o Valor do Produto: ");
                        var ValorProduto = double.Parse(Console.ReadLine());
                        operacoesMenu.CadastrarProduto(NomedoProduto, DescricaoDoProduto, TipoDoProduto, ValorProduto);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }
            }
        }
    }
}