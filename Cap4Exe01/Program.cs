using System;

namespace Cap4Exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");

            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }
        }
    }
}
