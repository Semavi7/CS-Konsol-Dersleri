namespace Ders8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, indirim, odenecek;

            Console.Write("Alışveriş Tutarını Giriniz: ");
            x=Convert.ToDouble(Console.ReadLine());

            if(x<100)
            {
                indirim = x * 10 / 100;
                odenecek=x-indirim;
                Console.WriteLine("İndirim Tutarı: " + indirim);
                Console.WriteLine("Toplam Ödenecek Tutarr: "+odenecek);
            }
            if(x>100 && x<150)
            {
                indirim = x * 15 / 100;
                odenecek = x-indirim;
                Console.WriteLine("İndirim Tutarı: "+indirim);
                Console.WriteLine("Toplam Ödenecek Tutar: " + odenecek);
            }
            if(x>150 && x<200)
            {
                indirim = x * 20 / 100;
                odenecek= x-indirim;
                Console.WriteLine("İndirim Tutarı: " + indirim);
                Console.WriteLine("Toplam Ödenecek Tutar: " + odenecek);
            }
        }
    }
}
