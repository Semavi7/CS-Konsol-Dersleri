namespace Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, proje, ort;

            Console.Write("1. Sınavı Giriniz: ");
            sinav1=Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sınavı Giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Proje Notunuzu Giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());

            ort = (sinav1 + sinav2 + proje) / 3;
            Console.WriteLine("Ortalama: "+ort);

            if (ort>0 && ort < 50) 
            {
                Console.WriteLine("Durum Kötü");
            }
            else if (ort>50 && ort < 70) 
            {
                Console.WriteLine("Durum İyi");
            }
            else if (ort>70 && ort<=100)
            {
                Console.WriteLine("Durum Çok İyi");
            }

        }
    }
}
