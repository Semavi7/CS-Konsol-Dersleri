namespace Ders7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Sayıyı Girin: ");
            sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (sayi % 5 == 0)
            {
                Console.WriteLine("Sayı 5'e Tam Bölünüyor");
            }
            else
            {
                Console.WriteLine("Sayı 5'e Tam Bölünmüyor");
            }
        }
    }
}
