using System.Reflection;

namespace Ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, karealan, karecevre;
            int kisakenar, uzunkenar, dikalan, dikcevre;

            Console.WriteLine("**** Karenin Alan ve Çevresini Bulma ****");
            Console.Write("Karenin Bir Kenarını Giriniz: ");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;

            Console.WriteLine("Kare Alan: "+karealan);
            Console.WriteLine("Kare Çevre: "+karecevre);

            Console.WriteLine();
            Console.WriteLine("**** Diktörtgen Alan ve Çevre Hesaplama ****");

            Console.Write("Kısa Kenar Giriniz: ");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenar Giriniz: ");
            uzunkenar= Convert.ToInt32(Console.ReadLine());
            dikalan=kisakenar*uzunkenar;
            dikcevre=kisakenar*2+uzunkenar*2;

            Console.WriteLine("Dikdötrgen Alan: "+dikalan);
            Console.WriteLine("Dikdörtgen Çevre: "+dikcevre);
        }
    }
}
