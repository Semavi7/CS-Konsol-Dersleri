﻿namespace Ders29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
