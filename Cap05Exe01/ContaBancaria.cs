using System.Globalization;

namespace Cap05Exe01
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Deposito(double qtd)
        {
            Saldo += qtd;
        }

        public void Saque(double qtd)
        {
            Saldo -= qtd + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}