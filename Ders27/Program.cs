namespace Ders27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Küçük Sayı: "+Math.Min(sayi1, sayi2));
        }
    }
}
