﻿namespace Ders24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[2, 3];

            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[0, 2] = 30;
            dizi[1, 0] = 40;
            dizi[1, 1] = 50;
            dizi[1, 2] = 60;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ",dizi[i, j]);
                }
                Console.WriteLine();
            } 
        }
    }
}
