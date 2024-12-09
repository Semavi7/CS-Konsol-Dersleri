namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, ort;

            Console.Write("1. Sınavınız: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sınavınız: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            ort = (sinav1 + sinav2) / 2;
            Console.WriteLine("Ortalama: " + ort);

            if (ort >= 50)
            {
                Console.WriteLine("Öğrenci Dersi Geçti");
            }
            else
            {
                Console.WriteLine("Öğrenci Dersten Kaldı");
            }
        }
    }
}
