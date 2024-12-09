namespace Ders21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort s1, s2;
            s1 = 0;
            s2 = 655;
            Console.WriteLine(s2 + s1);

            short s3, s4, s5;
            s3 = 20;
            s4= 30;
            s5= 40;
            Console.WriteLine(s3 + s4 + s5);

            Console.WriteLine("**** Doğu Anadolu Bölgesi Hava Durumu ****");
            Console.WriteLine("1 Ocak 2016 Hava Tahminleri");
            sbyte erzurum, malatya, elazıg;
            erzurum = -35;
            malatya = 3;
            elazıg = -7;
            Console.WriteLine("Erzurum Karlı: " + erzurum + " Derecedir");
            Console.WriteLine("Malatya Çok Bulutlu: " + malatya + " Derecedir");
            Console.WriteLine("Elazığ Karlı: " + elazıg + " Derecedir");
        }
    }
}
