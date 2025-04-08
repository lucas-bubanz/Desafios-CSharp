using ManagerBank.Enums;
using ManagerBank.Models;
using ManagerBank.Services;

namespace Banco
{
    class ManagerBank
    {
        static void Main(string[] args)
        {
            var ListaDeContas = new List<DadosBancarios>();
            var conta = new DadosBancarios("12345-6", "Joao", 1000.00m, EBancos.Nubank);
            var conta1 = new DadosBancarios("12345-7", "Maria", 2000.00m, EBancos.Santander);
            var conta2 = new DadosBancarios("12345-8", "Pedro", 3000.00m, EBancos.Banrisul);
            var conta3 = new DadosBancarios("12345-9", "Ana", 4000.00m, EBancos.C6Bank);
            ListaDeContas.Add(conta);
            ListaDeContas.Add(conta1);
            ListaDeContas.Add(conta2);
            ListaDeContas.Add(conta3);

            var operacoes = new Operacoes(conta);

            while (true)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Ver Saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Consultar Dados Bancários");
                Console.WriteLine("5 - Sair");

                var escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "5":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}