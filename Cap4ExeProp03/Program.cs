using System;
using System.Globalization;

namespace Cap4ExeProp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.SituacaoAluno();        
        }
    }
}
