﻿using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");
            string nig = Console.ReadLine();
            byte n = byte.Parse(nig);
            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
