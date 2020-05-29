using System;
using System.Globalization;

namespace Cap4ExeProp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a Largura e Altura do retangulo:");

            Retangulo r = new Retangulo();

            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
