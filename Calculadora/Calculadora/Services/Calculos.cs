using Calculadora.Interface.IOperacoesMatematicas;

namespace Calculadora.Services.Calculos
{
    public class CalculosMatematicos : IOperacoesMatematicas
    {
        public void dividir(float numeroDivisao1, float numeroDivisao2)
        {
            Console.Clear();
            Console.WriteLine($"A divisão de {numeroDivisao1} e {numeroDivisao2} é: {numeroDivisao1 / numeroDivisao2}");
        }

        public void multiplicar(float numeroMultiplicacao1, float numeroMultiplicacao2)
        {
            Console.Clear();
            Console.WriteLine($"A multiplicação de {numeroMultiplicacao1} e {numeroMultiplicacao2} é: {numeroMultiplicacao1 * numeroMultiplicacao2}");
        }

        public void restoDaDivisao(float numeroRestoDivisao1, float numeroRestoDivisao2)
        {
            Console.Clear();
            Console.WriteLine($"O resto divisão de {numeroRestoDivisao1} é: {numeroRestoDivisao1 % numeroRestoDivisao2}");
        }

        public void somar(float numeroSoma1, float numeroSoma2)
        {
            Console.Clear();
            Console.WriteLine($"A soma de {numeroSoma1} e {numeroSoma2} é: {numeroSoma1 + numeroSoma2}");
        }

        public void subtrair(float numeroSubtracao1, float numeroSubtracao2)
        {
            Console.Clear();
            Console.WriteLine($"A subtração de {numeroSubtracao1} e {numeroSubtracao2} é: {numeroSubtracao1 - numeroSubtracao2}");
        }
    }
}