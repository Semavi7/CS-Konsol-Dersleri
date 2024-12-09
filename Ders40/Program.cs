namespace Ders40
{
    internal class Program
    {
        static void arttir(out int s)
        {
            s = 12;
            s++;
        }
        static void arttir1(ref int n)
        {
            n++;
        }
        static void Main(string[] args)
        {
            int a = 9;
            arttir1 (ref a);
            Console.WriteLine (a);

            int b;
            arttir(out b);
            Console.WriteLine (b);
        }
    }
}
