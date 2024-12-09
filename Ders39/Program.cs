namespace Ders39
{
    internal class Program
    {
        class insan
        {
            public virtual void selamver()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Title = "Örnek Temmuz 2016";
                Console.WriteLine("Merhaba Sıcak Yaz Günleri");
            }
        }
        class Türk : insan
        {
            public override void selamver()
            {
                Console.WriteLine("Esenlikler");
            }
        }
        class Fransız : insan
        {
            public override void selamver()
            {
                Console.WriteLine("Bonjour");
            }
        }
        class Ingiliz : insan
        {
            public override void selamver()
            {
                Console.BackgroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Hi");
            }
        }
        static void Main(string[] args)
        {
            insan ins = new insan();
            ins.selamver();
            Türk türk = new Türk();
            türk.selamver();
            Fransız frn = new Fransız();
            frn.selamver();
            Ingiliz ing = new Ingiliz();
            ing.selamver();
        }
    }
}
