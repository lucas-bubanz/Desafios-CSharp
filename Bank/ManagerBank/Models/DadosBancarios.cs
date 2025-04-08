using ManagerBank.Enums;

namespace ManagerBank.Models
{
    public class DadosBancarios
    {
        public string IdDaConta { get; private set; }
        public string ContaBancaria { get; set; }
        public string NomeCliente { get; set; }
        public decimal Saldo { get; set; }
        public EBancos Banco { get; set; }

        public DadosBancarios(string contaBancaria, string nomeCliente, decimal saldo, EBancos banco)
        {
            IdDaConta = Guid.NewGuid().ToString().Substring(0, 8);
            ContaBancaria = contaBancaria;
            NomeCliente = nomeCliente;
            Saldo = saldo;
            Banco = banco;
        }
    }
}