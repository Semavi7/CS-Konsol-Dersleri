namespace Ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Hesaplama");
            double sinav1, sinav2, sinav3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine();

            Console.WriteLine("**** Öğrenci Kimlik Bilgiler ****");

            Console.WriteLine();

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("Numaranız: ");
            numara = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("**** Öğrenci Sınav Bilgileri ****");

            Console.WriteLine();

            Console.Write("Birinci Sınav: ");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Sınav: ");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçüncü Sınav: ");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje Notu: ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("**** Ortalama Değeri ****");
            Console.WriteLine();
            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
            Console.WriteLine("Ortalama: "+ort);
            

               
        }
    }
}
