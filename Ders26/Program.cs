namespace Ders26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("Satır Sayısını Giriniz: ");
            satir=Convert.ToInt16(Console.ReadLine());
            Console.Write("Sutun Sayısını Giriniz: ");
            sutun=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            int[,] matris= new int[satir,sutun];

            for(int i = 0; i < satir; i++)
            {
                for(int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrisin {0}x{1} Değeri: ",i+1,j+1);
                    matris[i,j]=Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for(int i = 0;i < satir; i++)
            {
                for (int j = 0;j < sutun; j++)
                {
                    Console.Write(matris[i,j]+" ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
            for (int i = 0; i< sutun; i++)
            {
                for( int j = 0; j< satir; j++)
                {
                    Console.Write(matris[j,i]+" ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
            int sayi;
            Console.Write("Matrisi Çarpmak İstediğiniz Sayıyi Giriniz: ");
            sayi= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            for( int i = 0; i<satir; i++)
            {
                for(int j=0;  j< sutun; j++)
                {
                    Console.Write(matris[i, j] * sayi + " ");
                }
                Console.WriteLine() ;
            }
        }
    }
}
