namespace Ders35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba();
            arbsnf.renk = "Siyah";
            arbsnf.fiyat = 150000;
            arbsnf.model = "2016";
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "16 Bursa";

            Console.WriteLine("Araba Rengi: " + arbsnf.renk);
            Console.WriteLine("Araba Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Araba Model: " + arbsnf.model);
            Console.WriteLine("Araba Vitesi: " + arbsnf.vites);
            Console.WriteLine("Araba Plaka: " + arbsnf.plaka);
        }
    }
}
