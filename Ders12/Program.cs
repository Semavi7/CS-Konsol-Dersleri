namespace Ders12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Faktöryeli Alınacak Sayıyı Girin :");
            sayi = Convert.ToInt16(Console.ReadLine());
            int faktöryel = 1;
            while (sayi > 1) 
            {
                faktöryel = faktöryel * sayi;
                sayi--;
            } 
            Console.WriteLine(faktöryel);
        }
    }
}
