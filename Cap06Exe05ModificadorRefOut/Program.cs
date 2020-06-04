using System;

namespace Cap06Exe05ModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref - Referencia no metodo Triple a variável int a, nao precisando que o metodo retorne 
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            // out

            int b = 10;
            int triple;
            Calculator.TripeOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
