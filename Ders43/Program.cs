namespace Ders43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 100);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.Write("Sayıyı Girin: ");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük sayı girin...");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük sayı girin...");
                }
            }
            Console.WriteLine("Tebriklerrrrr...");
            Console.WriteLine("{0}. denemede buldunuz", sayac);
            Console.Read();
        }
    }
}
