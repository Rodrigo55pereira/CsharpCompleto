using System;
using System.Globalization;

namespace Course
{
    class Program   
    {
        static void Main(string[] args)
        {
            /*
             * 
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

            //TIPOS DO DONET - System
            // SByte
            

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

            int n6 = 3 + 4 * 2;
            int n7 = (3 + 4) * 2;
            int n8 = 17 % 3;
            double n9 = 10.0 / 8;

            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);

            // Calculando a formula de bascara - equação segundo grau.

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // Quebrar a String
            string[] vet = Console.ReadLine().Split(' ');
            string j = vet[0];
            string e = vet[1];
            string w = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(w);

            */

            int n10 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n11 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n10);
            Console.WriteLine(ch);
            Console.WriteLine(n11.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
