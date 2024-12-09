namespace Ders38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucak uck = new Ucak();
            uck.Markası = "Türk Hava Yolları";
            uck.Kalkisi = "ADANA - şakirpaşa";
            uck.varisi = "İstanbul - Sabiha Gökçen";
            uck.Adi = "Baran";
            uck.Soyadi = "Yücedağ";
            uck.Yas = -28;
            uck.Cinsiyet = "Bay";

            Console.WriteLine("Hava Yolu: " + uck.Markası);
            Console.WriteLine("Kalkış Noktası: " + uck.Kalkisi);
            Console.WriteLine("Varış Noktası: " + uck.varisi);
            Console.WriteLine("Yolcu Adı: " + uck.Adi);
            Console.WriteLine("Yolcu Soyadı: " + uck.Soyadi);
            Console.WriteLine("Yolcu Yaşı: " + uck.Yas);
            Console.WriteLine("Yolcu Cinsiyeti: " + uck.Cinsiyet);
        }
    }
}
