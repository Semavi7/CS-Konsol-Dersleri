using System.Globalization;

namespace Ders42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("Aritmetik İşlemler Menüsüne Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("**************** MENÜ *****************\n");
            Console.WriteLine("1-Aritmetik Dört İşlem");
            Console.WriteLine("2-Üs Alma");
            Console.WriteLine("3-Kök Alma");
            Console.WriteLine("4-Karenin Çevre ve Alan Hesabı");
            Console.WriteLine("5-Dikdörtgenin Çevre ve Alan Hesabı");
            Console.WriteLine("6-Eşkenar Üçgenin Çevre Hesabı");

            Console.WriteLine("****************************************\n");

            git:
            Console.Write("\nİşlem Yapmak İstediğiniz Alan: ");
            islem = Convert.ToInt16(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    int s1, s2, toplama, fark, carpma, bölme;
                    Console.Write("1. Sayı: ");
                    s1= Convert.ToInt16(Console.ReadLine());
                    Console.Write("2. Sayı: ");
                    s2= Convert.ToInt16(Console.ReadLine());
                    toplama = s1 + s2;
                    fark = s1 - s2;
                    carpma = s1 * s2;
                    bölme = s1 / s2;
                    Console.WriteLine("Toplam: " + toplama);
                    Console.WriteLine("Fark: " + fark);
                    Console.WriteLine("Çarpma: " + carpma);
                    Console.WriteLine("Bölme: " + bölme);break;
                case 2:
                    double us, taban, sonuc;
                    Console.Write("Üs Sayısını Giriniz: ");
                    us = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Taban Sayısını Giriniz: ");
                    taban = Convert.ToDouble(Console.ReadLine());
                    sonuc = Math.Pow(taban, us);
                    Console.WriteLine("Sonuç: " + sonuc);break;
                case 3:
                    double sayi, kök;
                    Console.Write("Karekökü Alınacak Sayıyı Giriniz: ");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    kök = Math.Sqrt(sayi);break;
                case 4:
                    int kenar, cevre, alan;
                    Console.Write("Karenin Bir Kenarını Giriniz: ");
                    kenar = Convert.ToInt16(Console.ReadLine());
                    cevre = kenar * 4;
                    alan = kenar * kenar;
                    Console.WriteLine("Çevre: " + cevre);
                    Console.WriteLine("Alan: " + alan);break;
                case 5:
                    int kenark, kenaru, cevred, aland;
                    Console.Write("Uzun Kenarı Girin: ");
                    kenaru = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Kısa Kenarı Girin: ");
                    kenark = Convert.ToInt16(Console.ReadLine());
                    cevred = (kenaru + kenaru) * 2;
                    aland = kenaru * kenark;
                    Console.WriteLine("Çevresi: " + cevred);
                    Console.WriteLine("Alanı: " + aland);break;
                case 6:
                    int ukenar, cevreu;
                    Console.Write("Üçkenin Bir Kenarını Giriniz: ");
                    ukenar = Convert.ToInt16(Console.ReadLine());
                    cevreu = ukenar * 3;
                    Console.WriteLine("Çevre: " + cevreu);break;
                default:
                    Console.WriteLine("Yanlış bir değer girdiniz...");
                    goto git;
                    break;

            }


        }
    }
}
