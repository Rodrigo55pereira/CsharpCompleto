using System;
using System.Globalization;

namespace Cap4ExeProp04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotaçao do dólar ? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voce vai comprar ? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.ValorPagorEmReais(cotacao, qtd).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
