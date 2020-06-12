using System.Globalization;
using System;

namespace Cap07Exe04DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            System.Console.WriteLine(d1);
            System.Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            System.Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            System.Console.WriteLine(d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            System.Console.WriteLine(d4);
            
            DateTime d5 = DateTime.Today;
            System.Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            System.Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            System.Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            System.Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2000");
            System.Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            System.Console.WriteLine(d10);
            
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            System.Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            System.Console.WriteLine(d12);
        }
    }
}
