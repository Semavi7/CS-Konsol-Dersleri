namespace Ders26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, sonuc;

            Console.Write("A Değerini Giriniz: ");
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("B Değerini Giriniz: ");
            b=Convert.ToInt16(Console.ReadLine());
            Console.Write("C Değeriniz Giriniz: ");
            c=Convert.ToInt16(Console.ReadLine());
            Console.Write("D Değeriniz Giriniz: ");
            d=Convert.ToInt16(Console.ReadLine());

            sonuc=Math.Abs((a*d)- (b*c));

            Console.WriteLine("Determinant: "+sonuc);
        }
    }
}
