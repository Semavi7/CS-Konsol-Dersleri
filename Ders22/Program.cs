namespace Ders22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifreyi Girin: ");
            int sifre;
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 1234;
            Console.WriteLine("Şifre Doğrumu {0}", durum1);
        }
    }
}
