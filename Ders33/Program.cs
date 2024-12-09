namespace Ders33
{
    internal class Program
    {
        private static int kupu (int sayi)
        {
            int kupdeger = sayi * sayi * sayi;
            return kupdeger;
        }
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin: ");
            int s;
            s = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sonuç: "+kupu(s));
            Console.WriteLine();
            Console.Write("Metni Girin: ");
            string blg = Console.ReadLine();
            yazdir(blg);
        }
    }
}
