using System.IO;
namespace Ders48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gun;
            Console.Write("Gün Nosu Girin: ");
            gun = Convert.ToInt16(Console.ReadLine());
            StreamWriter dosya = new StreamWriter($@"D:\Günlük\Gün{gun}.txt");
            string veri;
            Console.WriteLine("Buraya Notu Yazın: ");
            veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
        }
    }
}
