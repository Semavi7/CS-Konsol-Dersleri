using System.Media;

namespace Ders45_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz...");
            Console.WriteLine("Katılan Tüm takımlara Başarılar Dileriz...\n");
            Console.Title = "C# Turnavası";
            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            a1 = rastgele.Next(0, 6);
            b1 = rastgele.Next(0, 6);
            c1 = rastgele.Next(0, 6);
            d1 = rastgele.Next(0, 6);

            a2 = rastgele.Next(0, 6);
            b2 = rastgele.Next(0, 6);
            c2 = rastgele.Next(0, 6);
            d2 = rastgele.Next(0, 6);

            a3 = rastgele.Next(0, 6);
            b3 = rastgele.Next(0, 6);
            c3 = rastgele.Next(0, 6);
            d3 = rastgele.Next(0, 6);

            if (sayac == 1)
            {
                

                Console.WriteLine("1. Hafta Skorları");
                Console.WriteLine("____________________");

                Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " Fenerbahçe");
                if (a1 > b1)
                {
                    gs = gs + 3;
                }
                if (b1 > a1)
                {
                    fb = fb + 3;
                }
                if (a1 == b1)
                {
                    gs = gs + 1;
                    fb = fb + 1;
                }
                Console.WriteLine("Beşiktaş " + c1 + "-" + d1 + " Trabzonspor");
                if (c1 > d1)
                {
                    bjk = bjk + 3;
                }
                if (d1 > c1)
                {
                    ts = ts + 3;
                }
                if (d1 == c1)
                {
                    ts = ts + 1;
                    bjk = bjk + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {
               

                Console.WriteLine("2. Hafta Skorları");
                Console.WriteLine("____________________");

                Console.WriteLine("Fenerbahçe " + b2 + "-" + c2 + " Beşiktaş");
                if (b2 > c2)
                {
                    fb = fb + 3;
                }
                if (c2 > b2)
                {
                    bjk = bjk + 3;
                }
                if (c2 == b2)
                {
                    fb = fb + 1;
                    bjk = bjk + 1;
                }
                Console.WriteLine("Trabzonspor " + d2 + "-" + a2 + " Galatasaray");
                if (d2 > a2)
                {
                    ts = ts + 3;
                }
                if (d2 > a2)
                {
                    gs = gs + 3;
                }
                if (d2 == a2)
                {
                    ts = ts + 1;
                    gs = gs + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 3)
            {
                

                Console.WriteLine("3. Hafta Skorları");
                Console.WriteLine("____________________");

                Console.WriteLine("Trabzonspor " + d3 + "-" + b3 + " Fenerbahçe");
                if (d3 > b3)
                {
                    ts = ts + 3;
                }
                if (b3 > d3)
                {
                    fb = fb + 3;
                }
                if (d3 == b3)
                {
                    ts = ts + 1;
                    fb = fb + 1;
                }
                Console.WriteLine("Beşiktaş " + c3 + "-" + a3 + " Galatasaray");
                if (c3 > a3)
                {
                    bjk = bjk + 3;
                }
                if (a3 > c3)
                {
                    gs = gs + 3;
                }
                if (a3 == c3)
                {
                    gs = gs + 1;
                    bjk = bjk + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 4)
            {
                
                Console.WriteLine("Maçlar Tamalandı....\n");
                Console.WriteLine("Puan Tablosu");
                Console.WriteLine("________________");
                Console.WriteLine("Galatasaray: " + gs);
                Console.WriteLine("Fenerbahçe: " + fb);
                Console.WriteLine("Beşiktaş: " + bjk);
                Console.WriteLine("Trabzonspor" + ts);
                
                int gsGol = a1 + a2 + a3;
                int fbGol = b1 + b2 + b3;
                int bjkGol = c1 + c2 + c3;
                int tsGol = d1 + d2 + d3;

                if (gs == fb)
                {
                    gs += (gsGol > fbGol) ? 1 : 0;
                    fb += (fbGol > gsGol) ? 1 : 0;
                }

                if (gs == bjk)
                {
                    gs += (gsGol > bjkGol) ? 1 : 0;
                    bjk += (bjkGol > gsGol) ? 1 : 0;
                }

                if (gs == ts)
                {
                    gs += (gsGol > tsGol) ? 1 : 0;
                    ts += (tsGol > gsGol) ? 1 : 0;
                }

                if (fb == bjk)
                {
                    fb += (fbGol > bjkGol) ? 1 : 0;
                    bjk += (bjkGol > fbGol) ? 1 : 0;
                }

                if (fb == ts)
                {
                    fb += (fbGol > tsGol) ? 1 : 0;
                    ts += (tsGol > fbGol) ? 1 : 0;
                }

                if (bjk == ts)
                {
                    bjk += (bjkGol > tsGol) ? 1 : 0;
                    ts += (tsGol > bjkGol) ? 1 : 0;
                }
            }

            Console.WriteLine("\nNihayi Puanlar");
            Console.WriteLine("________________");
            Console.WriteLine("Galatasaray: " + gs);
            Console.WriteLine("Fenerbahçe: " + fb);
            Console.WriteLine("Beşiktaş: " + bjk);
            Console.WriteLine("Trabzonspor" + ts);

            SoundPlayer ses = new SoundPlayer();
            string yol;
            if (gs > fb && gs > ts && gs > bjk)
            {
                Console.WriteLine("\nŞAMPİYON GALATASARAY");
                yol = @"C:\Users\semav\OneDrive\Desktop\Marslar\gs.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if (fb > gs && fb > ts && fb > bjk)
            {
                Console.WriteLine("\nŞAMPİYON FENERBAHÇE");
                yol = @"C:\Users\semav\OneDrive\Desktop\Marslar\fb.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if (bjk > fb && bjk > ts && bjk > gs)
            {
                Console.WriteLine("\nŞAMPİYON BEJİKTAŞ");
                yol = @"C:\Users\semav\OneDrive\Desktop\Marslar\bjk.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if (ts > fb && ts > gs && ts > bjk)
            {
                Console.WriteLine("\nŞAMPİYON TRABZONSPOR");
                yol = @"C:\Users\semav\OneDrive\Desktop\Marslar\ts.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            Console.Read();
        }
    }
}
