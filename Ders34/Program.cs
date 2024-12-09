namespace Ders34
{
    internal class Metotlar
    {
        int topla(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Metotlar mtr = new Metotlar();
            int z, a, s;
            Console.Write("Birinci Sayıyı Giriniz: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            s = Convert.ToInt16(Console.ReadLine());
            z = mtr.topla(a, s);
            Console.WriteLine("Toplam: " + z);
        }
    }
}
