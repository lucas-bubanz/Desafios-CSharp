using System;
using Calculadora.Services.Menu;
using Calculadora.Interface.IOperacoesMatematicas;

namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            var menu = new Menu();
            menu.ApresentarMenu();
        }
    }
}