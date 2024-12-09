namespace Ders25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrislerde Toplama");
            int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 41, 21 }, { 32, 36, 41, 57 },{ 20, 14, 16, 23 } };
            int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 8, 9, 6 }, { 21, 22, 23, 24 }, { 34, 35, 36, 37 } };
            int[,] toplam = new int[4, 4];
            
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            for(int i = 0;i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0;j < 4; j++)
                {
                    Console.Write(toplam[i, j]+" ");
                }
            }
        }
    }
}
