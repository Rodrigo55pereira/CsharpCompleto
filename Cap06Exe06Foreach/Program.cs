﻿using System;

namespace Cap06Exe06Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
