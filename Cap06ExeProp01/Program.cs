using System;

namespace Cap06ExeProp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be retend ? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine($"Rent # {i}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i
                    + ": "
                    + vect[i].Name
                    + ", "
                    + vect[i].Email);
                }
            }
        }
    }
}
