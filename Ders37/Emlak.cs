using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders37
{
    internal class Emlak
    {
        private string semt;
        private string renk;
        private int odasayisi;
        private double alan;

        public string semti
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string rengi
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }
        public double alani
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
