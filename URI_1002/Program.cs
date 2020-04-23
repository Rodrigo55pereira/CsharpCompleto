using System;
using System.Globalization;

namespace URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A={0} ", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
