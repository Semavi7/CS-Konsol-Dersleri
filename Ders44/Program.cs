using System.Media;
using System.Diagnostics;
namespace Ders44
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
            Console.Read();
            //Process.Start("C:\\Program Files (x86)\\Windows Media Player\\wmplayer.exe", @"C:\Users\semav\OneDrive\Desktop\Piyano-Dinletisi-_Dalga-Sesi.wav");
        }
    }
}
