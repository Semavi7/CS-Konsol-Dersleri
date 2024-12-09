namespace Ders14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write(i + 1 + " . Öğrencinin Adı: ");
                isim[i] = Console.ReadLine();

                Console.Write(i + 1 + " . Öğrencinin 1. Sınavı: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + " . Öğrencinin 2. Sınavı: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;
            }
            Console.WriteLine("Öğrenci\tSınav1\tSınav2\tOrtalama\n");
            Console.WriteLine();
            for (int i = 0;i < 3;i++)
            {
                Console.Write("{0}\t{1}\t{2}\t{3}", isim[i], s1[i], s2[i], ort[i]); // \t eşit aralık olmasını sağlıyor
                Console.WriteLine() ;
            }
        }
    }
}
