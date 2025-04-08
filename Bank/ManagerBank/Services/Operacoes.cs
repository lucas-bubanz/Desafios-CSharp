using ManagerBank.Models;
namespace ManagerBank.Services
{
    public class Operacoes
    {
        private readonly DadosBancarios _dadosBancarios;


        private decimal saldo = 1000.00m;

        public Operacoes(DadosBancarios dadosBancarios)
        {
            _dadosBancarios = dadosBancarios;
            saldo = dadosBancarios.Saldo;
        }
    }
}