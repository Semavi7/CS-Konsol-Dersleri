namespace Ders16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayıyı Giriniz: ");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Reverse(sayilar);
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Array.Sort(sayilar);
            Console.WriteLine("En Küçük Eleman: " + sayilar[0]);
            Console.WriteLine("En Büyük Eleman: " + sayilar[4]);
            Console.WriteLine("Dizinin Boyutu: " + sayilar.Length);
        }
    }
}
