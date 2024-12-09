namespace Ders20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal urun1, urun2, toplam;
            int s1, s2;

            urun1 = 14.85m;
            urun2 = 21.48m;

            Console.Write("1. Ürünün Satış Miktarı: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            toplam = s1*urun1 + s2*urun2;

            Console.WriteLine("\nGün Sonunda Kasada Olması Gereken Tutar: " + toplam + "TL dir.");
        }
    }
}
