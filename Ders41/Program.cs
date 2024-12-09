using System.Media;

namespace Ders41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = @"C:\Users\semav\OneDrive\Desktop\Piyano-Dinletisi-_Dalga-Sesi.wav";
            ses.SoundLocation = yol;
            ses.Play();

            Console.WriteLine("**********************\n");
            Console.WriteLine("Yarışmaya Hoş Geldiniz\n");
            Console.Title = "Bilgi Yarışması";
            string ad, soyad;
            Console.Write("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Başlıyoruz Enter Tuşuna Basın...");
            Console.WriteLine("Her Yanıttan Sonra Enter Tuşuna Basmayı Unutmayın...");
            Console.WriteLine("Cevapları BÜYÜK HARFLERLE Verin...");
            Console.ReadLine();
            int dogru, yanlıs, para;
            dogru = 0;
            yanlıs = 0;
            para = 0;

            string s1;
            Console.WriteLine("Soru 1. Cumhuriyet kaç yılında ilan edilmiştir?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine("A-1920\nB-1923\nC-1924\nD-1926\nCevabınız: ");
            c1 = Console.ReadLine();
            if (c1 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s2;
            Console.WriteLine("Soru 2. Türkiye'nin başkenti hangi şehirdir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine("A-Ankara\nB-Tokat\nC-Rize\nD-Samsun\nCevabınız: ");
            c2 = Console.ReadLine();
            if (c2 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s3;
            Console.WriteLine("Soru 3. Maki hangi bölgenin bitki örtüsüdür?");
            s3 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine("A-İçAnadolu\nB-Akdeniz\nC-Marmara\nD-DoğuAnadolu\nCevabınız: ");
            c3 = Console.ReadLine();
            if (c3 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s4;
            Console.WriteLine("Soru 4. Hangisi İstanbul'da bulunan bir semt değildir?");
            s4 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.WriteLine("A-Ümraniye\nB-Maltepe\nC-Karatay\nD-Kadıköy\nCevabınız: ");
            c4 = Console.ReadLine();
            if (c4 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s5;
            Console.WriteLine("Soru 5. Hangisi programlamanın temel renklerinden biri değildir?");
            s5 = Convert.ToString(Console.ReadLine());
            string c5;
            Console.WriteLine("A-Sarı\nB-Kırmızı\nC-Mavi\nD-Mor\nCevabınız: ");
            c5 = Console.ReadLine();
            if (c5 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s6;
            Console.WriteLine("Soru 6. Avrupa'nın kullandığı ortak para birimi hangisidir?");
            s6 = Convert.ToString(Console.ReadLine());
            string c6;
            Console.WriteLine("A-Ruble\nB-TürkLirası\nC-Euro\nD-Zloti\nCevabınız: ");
            c6 = Console.ReadLine();
            if (c6 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s7;
            Console.WriteLine("Soru 7. Hangi ilimiz Ege bölgesinde değildir?");
            s7 = Convert.ToString(Console.ReadLine());
            string c7;
            Console.WriteLine("A-İzmir\nB-Manisa\nC-Marmaris\nD-Konya\nCevabınız: ");
            c7 = Console.ReadLine();
            if (c7 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s8;
            Console.WriteLine("Soru 8. Sefiller kitabının yazarı kimdir?");
            s8 = Convert.ToString(Console.ReadLine());
            string c8;
            Console.WriteLine("A-Victor Hugo\nB-Alexandre Dumas\nC-Antonio Vivaldi\nD-Fyodor Dostoyevski\nCevabınız: ");
            c8 = Console.ReadLine();
            if (c8 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s9;
            Console.WriteLine("Soru 9. Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?");
            s9 = Convert.ToString(Console.ReadLine());
            string c9;
            Console.WriteLine("A-Gaziantep\nB-Kahramanmaraş\nC-Samsun\nD-Erzurum\nCevabınız: ");
            c9 = Console.ReadLine();
            if (c9 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            string s10;
            Console.WriteLine("Soru 10. İstiklal marşımızın şairi kimdir?");
            s10 = Convert.ToString(Console.ReadLine());
            string c10;
            Console.WriteLine("A-Namık Kemal\nB-Tefik Fikret\nC-Mehmet Akif Ersoy\nD-Orhan Pamuk\nCevabınız: ");
            c10 = Console.ReadLine();
            if (c10 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs++;
                Console.WriteLine("Maalesef cevap yanlış enter tuşuna basınız");
                Console.ReadLine();
            }

            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlıs);
            Console.WriteLine("Toplam Kazandığınız Para: " + para);
            Console.Read();
        }
    }
}
