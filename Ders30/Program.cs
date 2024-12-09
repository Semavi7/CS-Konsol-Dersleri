namespace Ders30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Karenin Kenar Sayısını Giriniz: ");
            int kare;
            kare = Convert.ToInt16(Console.ReadLine());

            //üst kenar
            for (int i = 0; i < kare; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            //sol kenar
            for (int i = 0; i < kare-2; i++)
            {
                Console.Write("*");
                //aradaki boşluklar
                for (int j = 0; j < kare-2; j++)
                {
                    Console.Write("  ");
                }
                //sağ kenar
                Console.Write(" *");
                Console.WriteLine();
            }
            //alt kenar
            for (int i = 0;i < kare; i++)
            {
                Console.Write("* ");
            }
        }
    }
}
