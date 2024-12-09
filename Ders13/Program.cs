namespace Ders13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[3];
            for (int i=0; i<3;  i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("**** Şehirler Listesi ****");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
        }
    }
}
