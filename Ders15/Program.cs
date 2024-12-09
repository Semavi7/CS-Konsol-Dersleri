namespace Ders15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            Console.Write("Faktöryeli Alınmak İstenen Sayı: ");
            j=Convert.ToInt32(Console.ReadLine());
            
            int[] degerler = new int[j];
            for (int i = 0; i < j; i++)
            {
                degerler[i] = i + 1;
            }

            
            int sonuc = 1;

            foreach (int i in degerler)
            {
                sonuc = sonuc * i;
            }
            Console.WriteLine();
            Console.WriteLine(degerler.Length+" Sayısının Faktöryeli: "+sonuc);
        }
    }
}
