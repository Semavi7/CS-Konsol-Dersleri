namespace Ders9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;

            Console.Write("Lütfen Şehri Giriniz: ");
            sehir = Console.ReadLine();

            switch(sehir)
            {
                case "Adana": Console.WriteLine("İstanbul Adana Arası Uzaklık 939km");break;
                case "Ankara": Console.WriteLine("İstanbul Ankara Arası Uzaklık 453km");break;
                case "Antalya": Console.WriteLine("İstanbul Antalya Arası Uzaklık 724km");break;
                case "Bursa": Console.WriteLine("İstanbul Bursa Arası Uzaklık 243km");break;
                case "Trabzon": Console.WriteLine("İstanbul Trabzon Arası Uzaklık 1070km");break;
                default: Console.WriteLine("Yalnız İfade Girdiniz");break;
            }

        }
    }
}
