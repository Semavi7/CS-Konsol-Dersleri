namespace Ders31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Baklava dilimi Sayısı: ");
            int deger;
            deger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= deger; i++)
            {
                for (int j = deger; j > i ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= deger; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = deger; k > i ; k--)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
