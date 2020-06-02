using System;
using System.Globalization;

namespace Cap05Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char confirmacaoDeposito = char.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria
            {
                NumeroConta = numeroConta,
                Titular = titular
            };

            if (confirmacaoDeposito == 's' || confirmacaoDeposito == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saldo = depositoInicial;

            }

            Console.WriteLine("Dados da conta: " + conta);

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: " + conta);

        }
    }
}
