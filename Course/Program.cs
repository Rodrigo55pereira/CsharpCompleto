using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS PRÉ DEFINIDOS
            sbyte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            bool completo = false;

            char genero = 'F';
            char letra = '\u0041';

            float n5 = 4.5f;

            string nome = "Maria Green";

            object obj1 = "Alex Dronw";

            /* TIPOS DO DONET - System
            SByte
            */

            int idade = 32;
            double saldo = 10.35784;

            n1++;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);

            Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde");

            Console.WriteLine("------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("f4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            // Interpolação de Strings
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            // Concatenação 
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}
