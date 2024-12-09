namespace Ders32
{
    internal class Program
    {
        private static void veriler()
        {
            Console.WriteLine("Müdür: Baran Yücedağ");
            Console.WriteLine("Öğretmen: Eylül Güneşli");
            Console.WriteLine("Okul: Atatürk Orta Okulu");
            Console.WriteLine("Eğitsel Kol: Kütüphanecilik");
            Console.WriteLine("Şehir: Bursa");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        static void Main(string[] args)
        {
            veriler();
        }
    }
}
