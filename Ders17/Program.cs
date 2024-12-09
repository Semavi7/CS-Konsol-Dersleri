namespace Ders17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            Console.WriteLine("**** Şehir Atama Programı ****");
            string[] sehirler = { "Adana", "Urfa", "Yozgat", "Sivas", "Mardin", "Ağrı" };
            int a;
            a = rasgele.Next(0, sehirler.Length);
            Console.WriteLine(a);
            Console.WriteLine(sehirler[a]);
        }
    }
}
