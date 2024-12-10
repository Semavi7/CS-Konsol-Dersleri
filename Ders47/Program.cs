namespace Ders47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("**************************************************");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**\tYEMEKLER\t**\tİÇEÇEKLER\t**");
            Console.WriteLine("**************************************************");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**  1.Et Döner-7.00TL\t**    7.Ayran-1.00TL\t**");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("** 2.Tavuk Döner-5.00TL\t**    8.Kola-3.00TL\t**");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**  3.Çorbalar-4.00TL\t**    9.Su-0.50TL\t**");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**  4.Salatalar-2.50TL\t**    10.Çay-0.75TL\t**");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**  5.Kuru/Pilav-6.00TL\t**    11.Fanta-2.00TL\t**");
            Console.WriteLine("**\t\t\t**\t\t\t**");
            Console.WriteLine("**  6.Pide-6.50TL\t**    12.Soda-1.00TL\t**");
            Console.WriteLine("**************************************************");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("");
                Console.Write("Alacağınız Ürünün Numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());
                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Porsiyon Tavuk Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Porsiyon Çorba: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap = hesap + toplam;
                }
                else if (secim == 4)
                {
                    Console.Write("Kaç Porsiyon Salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Kuru/Pilav: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Pide: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Adet Ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Adet Kola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Adet Su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Adet Çay: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.75;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Adet Fanta: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Soda: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else
                    Console.WriteLine("Böyle Bir Seçim Yok");   
                    Console.WriteLine();
                    Console.Write("Başka Bir İstediğiniz Var mı: ");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "Hayır" || cevap == "HAYIR") 
                    break;
                
            }
            Console.WriteLine("\nToplam Tutar: " + hesap);
            Console.Read();
        }
    }
}
