using Calculadora.Interface.IOperacoesMatematicas;

namespace Calculadora.Services.Calculos
{
    public class CalculosMatematicos : IOperacoesMatematicas
    {
        public void dividir(float numero1, float numero2)
        {
            Console.Clear();
            Console.WriteLine($"A divisão de {numero1} e {numero2} é: {numero1 / numero2}");
        }

        public void multiplicar(float numero1, float numero2)
        {
            Console.Clear();
            Console.WriteLine($"A multiplicação de {numero1} e {numero2} é: {numero1 * numero2}");
        }

        public void restoDaDivisao(float numero1, float numero2)
        {
            Console.Clear();
            Console.WriteLine($"O resto divisão de {numero1} é: {numero1 % numero2}");
        }

        public void somar(float numero1, float numero2)
        {
            Console.Clear();
            Console.WriteLine($"A soma de {numero1} e {numero2} é: {numero1 + numero2}");
        }

        public void subtrair(float numero1, float numero2)
        {
            Console.Clear();
            Console.WriteLine($"A subtração de {numero1} e {numero2} é: {numero1 - numero2}");
        }
    }
}