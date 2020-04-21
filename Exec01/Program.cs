using System;
using System.Globalization;

namespace Exec01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + " , cujo preço é $ " + preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine("Arrastando (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
