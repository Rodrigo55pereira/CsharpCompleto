using System.Globalization;
using System;
using System.Collections.Generic;

namespace Cap06ExeProp01Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listFunc = new List<Funcionario>();

            Console.Write("Quantos empregados vao ser registrados? ");
            int qtdFunc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFunc; i++)
            {
                Console.WriteLine($"Emplyoee {i}: ");
                Console.Write("Id: ");
                int identificador = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listFunc.Add(new Funcionario{Id = identificador,Name = name, Salary = salary});
            }

            Console.Write("Entre com o código do funcionário que terá o aumento do salário: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario func = listFunc.Find(x => x.Id == id);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                func.AumentarSalario(porc);
            }

            Console.WriteLine("Lista de funcionários atualizados:");
            foreach (Funcionario obj in listFunc)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
