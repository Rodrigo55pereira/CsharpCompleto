using System.Collections.Generic;
using System;

namespace Cap06Exe07Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Add - adiciona no final da lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Insert - indica qual a posicao a ser inserida.
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {   
                Console.WriteLine(obj);
            }

            // Prop count - tamanho da lista.
            Console.WriteLine("List count " + list.Count);

            // Find, FindLast - Encontrar primeiro ou último elemento da lista que satisfaca um predicado
            
            // string s1 = list.Find(Test);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s2);

            // FindIndex, FindLastIndex - Encontrar primeira ou a última posicao de elemento da lista que satisfaca um predicado.

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position: " + pos2);

            // FindAll - Filtrar a lista com base em um predicado.

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remove, RemoveAll, RemoveAt, RemoveRange - Remover elementos da lista.

            Console.WriteLine("-----------------------");
            list.Remove("Alexx");

            foreach(string obj in list)
            {   
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach(string obj in list)
            {   
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");
            // RemoveAt - Remove pela posicao.
            list.RemoveAt(2);
            foreach(string obj in list)
            {   
                Console.WriteLine(obj);
            }

            // RemoveRange - Remover os elementos de uma faixa.
            Console.WriteLine("-----------------------");
            list.RemoveRange(0,2);
            foreach(string obj in list)
            {   
                Console.WriteLine(obj);
            }

        }

        /*
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
        */
    }
}
