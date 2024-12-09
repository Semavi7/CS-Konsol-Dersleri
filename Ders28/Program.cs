namespace Ders28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;

            Console.WriteLine("**** C# DERSLERİ TARİH SAAT FONKSİYONLARI ****");
            Console.WriteLine("Kısa Tarih: " + zaman.ToString("d"));
            Console.WriteLine("Uzun Tarih: " + zaman.ToString("D"));
            Console.WriteLine("Tam Tarih: " + zaman.ToString("f"));
            Console.WriteLine("Tam Tarih2: " + zaman.ToString("F"));
            Console.WriteLine("Sayısal Tarih: " + zaman.ToString("g"));
            Console.WriteLine("Sayısal Tarih2: " + zaman.ToString("G"));
            Console.WriteLine("Ay: " + zaman.ToString("m"));
            Console.WriteLine("Biçim: " + zaman.ToString("r"));
            Console.WriteLine("Biçim2: " + zaman.ToString("s"));
            Console.WriteLine("Saat: " + zaman.ToString("t"));
            Console.WriteLine("Saat2: " + zaman.ToString("T"));
            Console.WriteLine("Yıl: " + zaman.ToString("Y"));
            Console.WriteLine("Yıl2: " + zaman.ToString("yy"));
        }
    }
}
