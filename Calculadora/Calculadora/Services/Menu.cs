using System;
using Calculadora.Services.Calculos;

namespace Calculadora.Services.Menu
{
    public class Menu
    {
        public (float numero1, float numero2) EntradaValores()
        {
            Console.Write("Digite o [primeiro] número: "); string? nr1 = Console.ReadLine();
            Console.Write("Digite o [segundo] número: "); string? nr2 = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(nr1) || String.IsNullOrWhiteSpace(nr2))
            {
                Console.WriteLine("O valor digitado não pode ser null, vazio ou com espaço em branco!");
            }
            float numero1 = float.Parse(nr1 ?? nameof(nr1));
            float numero2 = float.Parse(nr2 ?? nameof(nr2));
            return (numero1, numero2);
        }
        public void ApresentarMenu()
        {
            var calculosMatematicos = new CalculosMatematicos();
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Menu da Calculadora");
                Console.WriteLine("[1] - Somar.");
                Console.WriteLine("[2] - Subtração.");
                Console.WriteLine("[3] - Multiplicação.");
                Console.WriteLine("[4] - Divisão.");
                Console.WriteLine("[5] - Resto da Divisão.");
                Console.WriteLine("[6] - Sair.");
                Console.Write("Escolha uma opção: ");
                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        var valoresSoma = EntradaValores();
                        calculosMatematicos.somar(valoresSoma.numero1, valoresSoma.numero2);
                        break;
                    case "2":
                        var valoresSubtracao = EntradaValores();
                        calculosMatematicos.subtrair(valoresSubtracao.numero1, valoresSubtracao.numero2);
                        break;
                    case "3":
                        var valoresMultiplicacao = EntradaValores();
                        calculosMatematicos.multiplicar(valoresMultiplicacao.numero1, valoresMultiplicacao.numero2);
                        break;
                    case "4":
                        var valoresDivisao = EntradaValores();
                        calculosMatematicos.dividir(valoresDivisao.numero1, valoresDivisao.numero2);
                        break;
                    case "5":
                        var valoresRestoDivisao = EntradaValores();
                        calculosMatematicos.restoDaDivisao(valoresRestoDivisao.numero1, valoresRestoDivisao.numero2);
                        break;
                    case "6": return;
                    default:
                        Console.WriteLine("Entrada Inválida"); break;
                }
            }
        }
    }
}