namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, sehir;

            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Şehir: ");
            sehir=Console.ReadLine();

            Console.WriteLine("Ad: {0} Soyad: {1} Şehir: {2}",ad,soyad,sehir);
        }
    }
}
