using System;
using System.Globalization;

namespace Exec02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");

            string nome = Console.ReadLine();

            Console.WriteLine("Quantos Quartos tem na sua casa?");

            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}
