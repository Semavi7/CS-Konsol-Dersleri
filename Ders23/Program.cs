namespace Ders23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            ConsoleColor renk2 = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;
            Console.ForegroundColor = renk2;
            Console.Clear();
            Console.Title = "18 Mart 2016";
            Console.WriteLine("18 Mart Çanakkale Şehitleri Anma Günü");
        }
    }
}
