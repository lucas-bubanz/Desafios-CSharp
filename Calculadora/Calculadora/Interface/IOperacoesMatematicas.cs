using System;

namespace Calculadora.Interface.IOperacoesMatematicas
{
    public interface IOperacoesMatematicas
    {
        void somar(float numero1, float numero2);
        void subtrair(float numero1, float numero2);
        void multiplicar(float numero1, float numero2);
        void dividir(float numero1, float numero2);
        void restoDaDivisao(float numero1, float numero2);
    }
}