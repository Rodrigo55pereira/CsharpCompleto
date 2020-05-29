using System;
using System.Globalization;

namespace Cap4ExeProp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            f.AumentarSalario(porcentagem);

            Console.Write("Dados atualizados: " + f);
        }
    }
}
