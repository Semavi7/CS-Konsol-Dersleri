namespace Ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,x;
            int toplam = 0;

            Console.Write("Sayıyı Girin: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(i=1; i<=x; i+=2)
            {
                Console.WriteLine(i);
                toplam=toplam+i;
            }
            Console.WriteLine("Toplam: "+toplam);
        }
    }
}
