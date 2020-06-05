using System;

namespace Cap06Exe08Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);

            // Rank - retorna a quantidade de linhas da matriz.

            Console.WriteLine(mat.Rank);

            // GetLength(0) - retorna a quantidade de linhas da matriz 

            Console.WriteLine(mat.GetLength(0));

            // GetLength(1) - Retorno a quantidade de colunas.

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
