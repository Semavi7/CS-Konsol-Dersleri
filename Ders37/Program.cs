namespace Ders37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();
            eml.semti = "Şişli";
            eml.rengi = "Mavi";
            eml.Odasayisi = -4;
            eml.alani = -80;

            Console.WriteLine("Evin Bulunduğu Semt: " + eml.semti);
            Console.WriteLine("Evin Oda Renkleri: " + eml.rengi);
            Console.WriteLine("Evin Toplam Oda Sayisi: " + eml.Odasayisi);
            Console.WriteLine("Evin Toplam Alanı: " + eml.alani + " Metre Kare");
        }
    }
}
