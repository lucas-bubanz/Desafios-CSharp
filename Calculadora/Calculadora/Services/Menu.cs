using System;
using Calculadora.Services.Calculos;
using Calculadora.Interface.IOperacoesMatematicas;

namespace Calculadora.Services.Menu
{
    public class Menu
    {
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
                string? opacao = Console.ReadLine();

                switch (opacao)
                {
                    case "1":
                        Console.Write("Digite o [primeiro] número: "); string? nr1 = Console.ReadLine();
                        Console.Write("Digite o [segundo] número: "); string? nr2 = Console.ReadLine();
                        float numeroSoma1 = float.Parse(nr1 ?? throw new ArgumentNullException(nameof(nr1), "Entada do valor não pode ser nula ou vazia"));
                        float numeroSoma2 = float.Parse(nr2 ?? throw new ArgumentNullException(nameof(nr2), "Entada do valor não pode ser nula ou vazia"));
                        calculosMatematicos.somar(numeroSoma1, numeroSoma2);
                        break;
                    case "2":
                        Console.Write("Digite o [primeiro] número: "); string? nrSub1 = Console.ReadLine();
                        Console.Write("Digite o [segundo] número: "); string? nrSub2 = Console.ReadLine();
                        float numeroSubtracao1 = float.Parse(nrSub1 ?? throw new ArgumentNullException(nameof(nrSub1), "Entada do valor não pode ser nula ou vazia"));
                        float numeroSubtracao2 = float.Parse(nrSub2 ?? throw new ArgumentNullException(nameof(nrSub2), "Entada do valor não pode ser nula ou vazia"));
                        calculosMatematicos.subtrair(numeroSubtracao1, numeroSubtracao2);
                        break;
                    case "3":
                        Console.Write("Digite o [primeiro] número: "); string? nrMult1 = Console.ReadLine();
                        Console.Write("Digite o [segundo] número: "); string? nrMult2 = Console.ReadLine();
                        float numeroMultiplicacao1 = float.Parse(nrMult1 ?? throw new ArgumentNullException(nameof(nrMult1), "Entada do valor não pode ser nula ou vazia"));
                        float numeroMultiplicacao2 = float.Parse(nrMult2 ?? throw new ArgumentNullException(nameof(nrMult2), "Entada do valor não pode ser nula ou vazia"));
                        calculosMatematicos.multiplicar(numeroMultiplicacao1, numeroMultiplicacao2);
                        break;
                    case "4":
                        Console.Write("Digite o [primeiro] número: "); string? nrDiv1 = Console.ReadLine();
                        Console.Write("Digite o [segundo] número: "); string? nrDiv2 = Console.ReadLine();
                        float numeroDivisao1 = float.Parse(nrDiv1 ?? throw new ArgumentNullException(nameof(nrDiv1), "Entada do valor não pode ser nula ou vazia"));
                        float numeroDivisao2 = float.Parse(nrDiv2 ?? throw new ArgumentNullException(nameof(nrDiv2), "Entada do valor não pode ser nula ou vazia"));
                        calculosMatematicos.dividir(numeroDivisao1, numeroDivisao2);
                        break;
                    case "5":
                        Console.Write("Digite o [primeiro] número: "); string? nrRestDiv1 = Console.ReadLine();
                        Console.Write("Digite o [segundo] número: "); string? nrRestDiv2 = Console.ReadLine();
                        float numeroRestoDivisao1 = float.Parse(nrRestDiv1 ?? throw new ArgumentNullException(nameof(nrRestDiv1), "Entada do valor não pode ser nula ou vazia"));
                        float numeroRestoDivisao2 = float.Parse(nrRestDiv2 ?? throw new ArgumentNullException(nameof(nrRestDiv2), "Entada do valor não pode ser nula ou vazia"));
                        calculosMatematicos.restoDaDivisao(numeroRestoDivisao1, numeroRestoDivisao2);
                        break;
                    case "6": return;
                    default:
                        Console.WriteLine("Entrada Inválida"); break;
                }
            }
        }
    }
}