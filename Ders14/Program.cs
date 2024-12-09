namespace Ders14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for (int i=0; i<5;  i++)
            {
                Console.Write((i+1).ToString()+" .Sayıyı Girin: ");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine();
            int enbuyuk;
            enbuyuk = sayilar[0];
            for (int i=0; i<5;i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }
            }
            Console.WriteLine(enbuyuk);
        }
    }
}
