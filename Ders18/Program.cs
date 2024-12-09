namespace Ders18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ders;
            Console.WriteLine("**** YGS DERSLRİ MENÜSÜ ****");
            Console.WriteLine("Türkçe....");
            Console.WriteLine("Matematik....");
            Console.WriteLine("Sosyal Bilgiler....");
            Console.WriteLine("Fen Bilgisi....");

            Console.WriteLine("Hangi Dersin Bilgilerini Görmek İstersiniz");
            ders=Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            if (ders == 't' || ders == 'T')
            {
                Console.WriteLine("Türkçe Dersi Paragraf Ağırlıklı Olup Dilbilgisi Soruları İçerir.");
            }
            else if (ders == 'm' || ders == 'M')
            {
                Console.WriteLine("Matematik Dersi Temel Matematik ve Geometri Soruları İçerir.");
            }
            else if (ders == 's' || ders == 'S')
            {
                Console.WriteLine("Sosyal Bilgiler Dersi Tarih ve Çoğrafya Soruları İçerir.");
            }
            else if(ders == 'f' || ders == 'F')
            {
                Console.WriteLine("Fen Bilgisi Dersi Fizik, Kimya ve Biyoloji Soruları İçerir.");
            }
            else
            {
                Console.WriteLine("Yanlış İfade Girdiniz...");
            }
        }
    }
}
