﻿using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Digite a quantidade de loops para a sequência Fibonacci");
            int n;
            int x = 1, y = 0, z = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }
            
        }
    }











