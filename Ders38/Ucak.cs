using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders38
{
    internal class Ucak:Yolcu
    {
        private string marka;
        private string kalkis;
        private string varis;

        public string Markası
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        public string Kalkisi
        {
            get { return kalkis; }
            set { kalkis = value.ToLower(); }
        }
        public string varisi
        {
            get { return varis; }
            set { varis = value.ToUpper(); }
        }
    }
}
