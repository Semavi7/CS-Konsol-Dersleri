namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int sinav1, sinav2, sinav3, proje,ort;

            Console.WriteLine("**** Öğrenci Bilgi ****");
            Console.WriteLine();
            ad = "Mehmet";
            soyad = "Yücedağ";
            numara = "1151";

            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Numara: " + numara);

            Console.WriteLine();
            Console.WriteLine("**** Not Bilgi ****");
            Console.WriteLine();

            sinav1 = 60;
            sinav2 = 70;
            sinav3 = 100;
            proje = 90;

            Console.WriteLine("Sinav1: " + sinav1);
            Console.WriteLine("Sinav2: " + sinav2);
            Console.WriteLine("Sinav3: " + sinav3);
            Console.WriteLine("Proje: " + proje);

            Console.WriteLine();
            Console.WriteLine("**** Ortalama Biligi ****");
            Console.WriteLine();

            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
            Console.WriteLine("Ortalama: "+ort);
        }
    }
}
