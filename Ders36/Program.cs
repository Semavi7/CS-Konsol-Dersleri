namespace Ders36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Baran";
            ogrenci.Soyad = "Yücedağ";
            ogrenci.Alan = "Türkçe Matematik";
            ogrenci.Yas = 26;

            Console.WriteLine("Adı: " + ogrenci.Adi);
            Console.WriteLine("Soyadı: " + ogrenci.Soyad);
            Console.WriteLine("Alanı: " + ogrenci.Alan);
            Console.WriteLine("Yaşı: " + ogrenci.Yas);
        }
    }
}
