namespace Ders11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c,e;

            

            Console.Write("Fibonaccinin Kaç Elemanını İstiyorsunuz: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i=1; i<=e;  i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.WriteLine();
            Console.WriteLine();

            int sayi = 120;

            for(int j=1; j<=120;  j++)
            {
                if(sayi %j==0)
                {
                    Console.WriteLine(j);
                }
                
            }
        }
    }
}
